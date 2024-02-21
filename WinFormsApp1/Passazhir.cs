using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Passazhir
    {
        public string fio;
        public string name;
        public int seriya;
        public int nomer;
        public DateTime datarozhdeniya;
        private (string, string, int, int, DateTime) value;
        private string text1;
        private string text2;
        private DateTime value1;
        private int v1;
        private int v2;

        public Passazhir(string fio, string name, int seriya, int nomer, DateTime datarozhdeniya)
        {
            this.fio = fio;
            this.name = name;
            this.seriya = seriya;
            this.nomer = nomer;
            this.datarozhdeniya = datarozhdeniya;
        }

        public Passazhir(string text, string text1, DateTime value1, int v, (string, string, int, int, DateTime) value)
        {
            this.value = value;
        }

        public Passazhir(string text1, string text2, DateTime value1, int v1, int v2)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.value1 = value1;
            this.v1 = v1;
            this.v2 = v2;
        }

        public string Fio()
        {
            return this.fio;
        }

        public string Name()
        {
            return this.name;
        }

        public int ser()
        {
            return this.seriya;
        }

        public int nom()
        {
            return this.nomer;
        }

        public DateTime data()
        {
            return this.datarozhdeniya;
        }
    }
}