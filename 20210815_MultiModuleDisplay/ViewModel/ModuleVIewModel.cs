using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace _20210815_MultiModuleDisplay.ViewModel
{
  public  class ModuleVIewModel:ViewModelBase
    {
        public ModuleVIewModel()
        {
            DataList = new List<DataInfo>();
            for (int i = 0; i < 10; i++)
            {
                var Row = new DataInfo();
                Row.Title = "Module" + i.ToString("D2");
                Row.HeaderString = "Haha" + i;
                DataList.Add(Row);
            }
        }


        private List<DataInfo> _dataList;

        public List<DataInfo> DataList
        {
            get { return _dataList; }
            set { _dataList = value; }
        }


        public class DataInfo : BindableBase
        {
            private string title;

            public string Title
            {
                get { return title; }
                set { title = value; RaisePropertiesChanged(nameof(Title)); }
            }

            private string header;

            public string HeaderString
            {
                get { return header; }
                set { header = value; RaisePropertiesChanged(nameof(HeaderString)); }
            }

        }

    }


}
