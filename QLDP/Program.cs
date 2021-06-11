using System;
using System.Text;
using QLDP.entity;
using QLDP.model;
using QLDP.view;

namespace QLDP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var duongPhoView = new DuongPhoView();
            duongPhoView.ShowMenu();

        }
    }
}