/*
 * HOSPITALIZATION CHARGES CALCULATOR
 * Version : 1.0.0
 * Author : Ajaypal Singh
 * Note : Currently Project is Not Handle Any Input Exception :( 
*/
using System;

namespace PrabhSimran_CSIS1175_AS1
{
    class Program
    {
        /* Basic App Info */

        string appName = "HOSPITALIZATION CHARGES CALCULATOR";
        string appVersion = "1.0.0";
        string appAuthor = "Ajaypal Singh";

        /* Variable Declaration */

        string patientName = "";
        string levelCare = "";
        int levelCareValue = 0;
        int hosdays = 1;

        /* Diffirent Medical Tests Charges */

        int colonoscopyCharges = 0;
        int cystologyCharges = 0;
        int ctScanCharges = 0;
        int urineAnalysisCharges = 0;
        int stoolAnalysisCharges = 0;
        int bloodAnalysisCharges = 0;
        int medicationCharges = 0;
        int rehabCharges = 0;

        /* Calculate Stay Charges */

        int CalcStayCharges()
        {
            int stayCharges = this.levelCareValue * this.hosdays;
            return stayCharges;
        }

        /* Calculate Diagnostic Charges */

        int CalcDiagnosticCharges()
        {
            int diagnosticCharges = this.colonoscopyCharges + this.cystologyCharges + this.ctScanCharges;
            return diagnosticCharges;
        }

        /* Calculate Lab Test Charges */

        int CalcLabCharges()
        {
            int labCharges = this.urineAnalysisCharges + this.stoolAnalysisCharges + this.bloodAnalysisCharges;
            return labCharges;
        }

        /* Miscellaneous Charges */

        int CalcMiscCharges()
        {
            int miscCharges = this.medicationCharges + this.rehabCharges;
            return miscCharges;
        }

        /* Function Show Basic App Info Output To Console */

        void showAppInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t" + this.appName);
            Console.WriteLine("\t\t\tVersion : " + this.appVersion);
            Console.WriteLine("\t\t\tAuthor : " + this.appAuthor);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        /* Print Final Output */

        void printRecipt()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************************");
            Console.WriteLine("Patient Name : " + this.patientName);
            Console.WriteLine("Level of Care : " + this.levelCare);
            Console.WriteLine("Level of Daily Cost : " + this.levelCareValue);
            Console.WriteLine("Days Hospitalized : " + this.hosdays);
            Console.WriteLine("Stay Charges : $" + CalcStayCharges());
            Console.WriteLine("Diagnostic Charges : $" + CalcDiagnosticCharges());
            Console.WriteLine("Lab Analysis Charges : $" + CalcLabCharges());
            Console.WriteLine("Medication and Rehab Charges : $" + CalcMiscCharges());
            Console.WriteLine("Total Charges : $" + (CalcStayCharges() + CalcDiagnosticCharges() + CalcLabCharges() + CalcMiscCharges()));
            Console.WriteLine("****************************************");
        }

        /* Main Entry Point of Application */
        static void Main(string[] args)
        {

            Program prg = new Program(); // Create Object of Class
            prg.showAppInfo();  // Show Basic Aapp Info

            Console.Write("Please Enter Patient’s Name : ");
            prg.patientName = Console.ReadLine(); // Input patient name

            Console.WriteLine();
            Console.WriteLine("Level of Care :");
            Console.WriteLine("1. Level 1 -> $350");
            Console.WriteLine("2. Level 2 -> $500");
            Console.WriteLine("3. Level 3 -> $1250");
            Console.WriteLine("4. Level 4 -> $2500");
            Console.WriteLine();
            Console.Write("Please Enter Level of Care : ");
            int levelCareInput = int.Parse(Console.ReadLine()); // Input level of care

            /* set level care value according to input */

            switch (levelCareInput)
            {
                case 1:
                    prg.levelCare = "Level 1";
                    prg.levelCareValue = 350;
                    break;
                case 2:
                    prg.levelCare = "Level 2";
                    prg.levelCareValue = 500;
                    break;
                case 3:
                    prg.levelCare = "Level 3";
                    prg.levelCareValue = 1250;
                    break;
                case 4:
                    prg.levelCare = "Level 4";
                    prg.levelCareValue = 2500;
                    break;
                default:
                    /* on wrong input Of Levelofcare and recall input once again (out of range input from 1 to 4)*/
                    System.Console.WriteLine("Please Enter Valid Input");
                    Console.Write("Please Enter Level of Care : ");
                    levelCareInput = int.Parse(Console.ReadLine());
                    break;
            }

            /* Input DaysHospitalized */

            Console.Write("Please Enter Number of Days Hospitalized : ");
            prg.hosdays = int.Parse(Console.ReadLine());

            /* Input Diagnostic Charges */

            Console.Write("Please Enter Colonoscopy Charges : ");
            prg.colonoscopyCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Cystology Charges : ");
            prg.cystologyCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter CT Scan Charges : ");
            prg.ctScanCharges = int.Parse(Console.ReadLine());

            /* Input Lab Tests Charges */

            Console.Write("Please Enter Urine Analysis Charges : ");
            prg.urineAnalysisCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Stool analysis Charges : ");
            prg.stoolAnalysisCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Blood Analysis Charges : ");
            prg.bloodAnalysisCharges = int.Parse(Console.ReadLine());

            /* Input Miscellaneous Charges */

            Console.Write("Please Enter Medication Charges : ");
            prg.medicationCharges = int.Parse(Console.ReadLine());

            Console.Write("Please Enter Rehab Charges : ");
            prg.rehabCharges = int.Parse(Console.ReadLine());

            /* calling final function to output final details with calculation */
            prg.printRecipt();
            Console.ReadKey();
        }
    }
}
