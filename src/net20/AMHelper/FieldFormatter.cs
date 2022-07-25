using System;
using System.Collections.Generic;
using System.Text;

namespace AMHelper
{
    public static class FieldFormatter
    {

        /// <summary>
        /// Utilizzato nella creazione dei tracciati ascii (es: ordini)
        /// </summary>
        /// <param name="DataValue"></param>
        /// <returns></returns>
        static public string Date2String2(DateTime? DataValue)
        {
            string retVal = "";

            if (DataValue.HasValue)
                retVal = Convert.ToDateTime(DataValue).ToString("ddMMyyyy");

            return retVal;
        }



        /// <summary>
        /// Utilizzato nella creazione dei tracciati ascii (es: note cliente)
        /// </summary>
        /// <param name="Testo"></param>
        /// <returns></returns>
        static public string Newline2Char2(string Testo)
        {

            string Retval = "";

            if (String.IsNullOrEmpty(Testo))
            {
                Retval = "";
            }
            else
            {
                Retval = Testo.Replace("|", "_");
                Retval = Retval.Replace(Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString(), Convert.ToChar(10).ToString());
                Retval = Retval.Replace(Convert.ToChar(10).ToString(), Convert.ToChar(13).ToString());
                Retval = Retval.Replace(Convert.ToChar(13).ToString(), "§");

                if (Retval.Length > 4000)
                {
                    Retval = Retval.Substring(1, 4000);
                }
            }


            return Retval;
        }


        /// <summary>
        /// Utilizzato nella crezione di tracciati ascii (es: note clienti)
        /// </summary>
        /// <param name="Testo"></param>
        /// <returns></returns>
        static public string Newline2Char(string Testo)
        {

            string Retval = "";

            if (String.IsNullOrEmpty(Testo))
            {
                Retval = "";
            }
            else
            {
                Retval = Testo.Replace("|", "_");
                Retval = Retval.Replace(Convert.ToChar(13).ToString() + Convert.ToChar(10).ToString(), Convert.ToChar(10).ToString());
                Retval = Retval.Replace(Convert.ToChar(10).ToString(), Convert.ToChar(13).ToString());
                Retval = Retval.Replace(Convert.ToChar(13).ToString(), "§");

                if (Retval.Length > 4000)
                {
                    Retval = Retval.Substring(1, 4000);
                }
            }


            return Retval;
        }


        // -------------------------

        /// <summary>
        /// Utilizzato nell'import dei tracciati (es: import io_art.dat)
        /// </summary>
        /// <param name="DataString"></param>
        /// <returns></returns>
        static public DateTime String2DateUltMod(string DataString)
        {
            System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;

            string format = "ddMMyyyyHHmmss";

            DateTime Result;
            try
            {
                Result = DateTime.ParseExact(DataString, format, provider);
            }
            catch
            {
                Result = DateTime.Now;
            }

            return Result;
        }

        /// <summary>
        /// Utilizzato nell'import dei tracciati (es: import imp_clifor_note.dat)
        /// </summary>
        /// <param name="Testo"></param>
        /// <returns></returns>
        static public string Char2Newline(string Testo)
        {

            string Retval = "";

            if (String.IsNullOrEmpty(Testo))
            {
                Retval = "";
            }
            else
            {
                Retval = Testo.Replace(@"§", System.Environment.NewLine);

                if (Retval.Length > 4000)
                {
                    Retval = Retval.Substring(1, 4000);
                }
            }


            return Retval;
        }

        /// <summary>
        /// Utilizzato nell'import dei tracciati io_righe_documenti.dat
        /// </summary>
        /// <param name="DataString"></param>
        /// <returns></returns>
        static public Nullable<DateTime> String2Date(string DataString)
        {
            //DateTime retVal;


            if (!String.IsNullOrEmpty(DataString))
            {
                if (DataString.Contains("-") || DataString.Contains("-"))
                {

                    DataString = DataString.Replace(@"-", @"");
                    DataString = DataString.Replace(@"/", @"");

                }
                System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;

                string format = "ddMMyyyy";
                Nullable<DateTime> DataConvertita = null;

                try
                {
                    DataConvertita = DateTime.ParseExact(DataString, format, provider);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERR: Errore in conversione stringa" + ex.Message);
                }

                return DataConvertita;

            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Utilizzato nell'import di tracciati (es:io_art.dat)
        /// </summary>
        /// <param name="DecimalString"></param>
        /// <returns></returns>
        static public Nullable<Decimal> String2Decimal(string DecimalString)
        {
            Decimal? DecimalConvertito;

            if (!String.IsNullOrEmpty(DecimalString))
            {
                DecimalConvertito = Convert.ToDecimal(DecimalString);
            }
            else
            {
                DecimalConvertito = null;
            }
            return DecimalConvertito;
        }

        static public string Date2String(DateTime? DataValue)
        {
            string retVal = "";

            if (DataValue.HasValue)
                retVal = Convert.ToDateTime(DataValue).ToString("ddMMyyyy");

            return retVal;
        }

        static public string StringToEnumInt(string value)
        {
            var content = (Urgenza)Enum.Parse(typeof(Urgenza), value);
            return ((int)(content)).ToString();
        }

        static public string Decompone(string value)
        {
            if (value.Contains("Urgente"))
            {
                return "Urgente";
            }
            else if (value.Contains("Normale"))
            {
                return "Normale";
            }
            else if (value.Contains("Corriere"))
            {
                return "Corriere";
            }
            else if(value.Contains("Agente"))
            {
                return "Agente";
            }

            return string.Empty;
        }

    }
}
