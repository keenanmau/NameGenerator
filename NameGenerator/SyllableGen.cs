using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator {
    class SyllableGen {
        String[] syllableList;

        Random rnd ;

        public SyllableGen() {
            rnd = new Random();
            syllableList = new String[10];
            syllableList[0] = "mon";
            syllableList[1] = "ryl";
            syllableList[2] = "lor";
            syllableList[3] = "pos";
            syllableList[4] = "cin";
            syllableList[5] = "arl";
            syllableList[6] = "urn";
            syllableList[7] = "omp";
            syllableList[8] = "dri";
            syllableList[9] = "san";

        }

        public String GetAName() {
            String firstName = "";
            int syllableLength = rnd.Next(2, 6);
            for(int i = 0; i < syllableLength; i++) {
                firstName += syllableList[rnd.Next(0, 10)];
            }

            return CapFirstLetter(firstName);
        }

        private String CapFirstLetter(String word) {
            return word.First().ToString().ToUpper() + String.Join("", word.Skip(1));
        }
    }


}
