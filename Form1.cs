using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigrations
{
    public partial class Form1 : Form
    {

        /*
         Üniversite için öğrenci bilgi sistemi uygulaması yaptığınızı düşünün. 

            - Ogrenci
            - Eğitmen
            - Ders
            - Fakülte
            - Bölüm           

            + Öğrenci ile Eğitmen ilişkisi (danışman eğitmen) 1-n 
            + öğrenci ile ders n-n
            + fakülte ile bölüm 1-n
            + bolüm ile öğrenci 1-n
            + bölüm ile ders n-n 
            + eğitmen ile ders 1-n
             
             
             */
        public Form1()
        {
            InitializeComponent();
        }
    }
}
