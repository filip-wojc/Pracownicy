using Pracownicy.LoadingFiles;
using Pracownicy.Models;
using Pracownicy.SavingFIles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy.Presenters
{
    public class PracownikPresenter
    {
        private Models.IPracownikRepository _repository;
        private Views.IPracownikView _view;
        private IEnumerable<Models.Pracownik> _pracownicyList;

        public PracownikPresenter(Views.IPracownikView view, Models.IPracownikRepository repozytorium)
        {
            _view = view;
            _repository = repozytorium;

            _view.AddNewPracownikEvent += AddPracownik;
            _view.SerializePracownikRepository += SerializePracownik;
            _view.DeserializePracownikRepository += DeserializePracownik;
            _pracownicyList = _repository.GetAll();
            
        }
        private void AddPracownik(object sender, EventArgs e)
        {
            if (_view.setEmptyErrorTextBox() && _view.setEmptyErrorTextBox()
                && _view.setEmptyErrorComboBox() && _view.setEmptyErrorRadioButton())
            {
                var pracownik = new Models.Pracownik(_view.Name, _view.Surname, _view.DateOfBirth, _view.Salary, _view.Job, _view.Agreement);
                _repository.Add(pracownik);
                _pracownicyList = _repository.GetAll();
                
                _view.DataGridUpdate(pracownik);

                _view.Name = "";
                _view.Surname = "";
                _view.DateOfBirth = DateTime.Now.ToString();
                _view.Salary = 0;
                _view.Job = "";
            }
                
        }
        private void SerializePracownik(object sender, EventArgs e)
        {
            SaveState saveState = new SaveState();

            using (SaveFileDialog fd = new SaveFileDialog())
            {
                DialogResult dialogResult = fd.ShowDialog();
                fd.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    if (fd.FileName.EndsWith("txt"))
                    {
                        saveState.SaveEmployeesToTxtFile(_pracownicyList, fd.FileName);
                    }
                    else if (fd.FileName.EndsWith("xml"))
                    {
                        saveState.SaveEmployeesToXMLFile(_pracownicyList, fd.FileName);
                    }
                    else
                    {
                        MessageBox.Show("Dozwolone formaty to txt i xml!");
                        return;
                    }

                }
            }
        }

        private void DeserializePracownik(object sender, EventArgs e)
        {
            LoadState loadState = new LoadState();

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Pliki tekstowe (*.txt)|*.txt|Pliki XML (*.xml)|*.xml";
                fd.FilterIndex = 1;
                fd.RestoreDirectory = true;

                DialogResult dialogResult = fd.ShowDialog();
                if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(fd.FileName))
                {
                    if (fd.FileName.EndsWith("txt"))
                    {
                        
                        _pracownicyList = loadState.LoadEmployeesFromTxtFile(fd.FileName);
                        foreach(var p in _pracownicyList)
                        {
                            _repository.Add(p);
                            _view.DataGridUpdate(p);
                        }

                    }
                    else if (fd.FileName.EndsWith("xml"))
                    {
                        _pracownicyList = loadState.LoadEmployeesFromXMLFile(fd.FileName);
                        foreach (var p in _pracownicyList)
                        {
                            _repository.Add(p);
                            _view.DataGridUpdate(p);
                        }

                    }

                   
                }

            }
        }
    }
}
