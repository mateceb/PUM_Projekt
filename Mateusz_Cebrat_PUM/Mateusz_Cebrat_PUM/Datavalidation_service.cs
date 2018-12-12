using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mateusz_Cebrat_PUM
{
    class Datavalidation_service
    {
        public bool Checking_letters(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^a-z, ,A-Z,ą,ę,ć,ł,ż,ź,ó,,,/]"))
            {
                
                return true;
            }
            return false;
        }

        public bool Checking_numbers(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^0-9,,]"))
            {

                return true;
            }
            return false;
        }

        public bool Checking_data(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^0-9,.]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_sex(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^m,k,M,K]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_time(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^0-9,:]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_measurements(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^0-9,,,/]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_information(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^a-z, ,A-Z,ą,ę,ć,ł,ż,ź,ó,,,/]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_group(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^A,B,a,b,0]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_rh(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^+,-,p,l,u,s,m,i,n]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_datainformation(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^a-z, ,A-Z,ą,ę,ć,ł,ż,ź,ó,,,/,-]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_confirm(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^T,N,t,n,a,A,k,K,e,E,i,I]"))
            {
                return true;
            }
            return false;
        }

        public bool Checking_adress(string box)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(box, "[^a-z,A-Z,1-9, ,ą,ę,ć,ł,ż,ź,ó,,,/,-,.]"))
            {
                return true;
            }
            return false;
        }
    }
}
