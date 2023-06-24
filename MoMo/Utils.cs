using Microsoft.EntityFrameworkCore;
using MoMo.Model;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoMo.Model.Transaction;

namespace MoMo
{
    public static class Utils
    {
        public static string FormatVNCurrency(double amount, bool isShorten = false, bool isCurrencyHidden = false)
        {
            if (isShorten)
            {
                if (amount >= 1000000000)
                    return (amount / 1000000000).ToString("0.#") + " tỷ";
                if (amount >= 1000000)
                    return (amount / 1000000).ToString("0.#") + " tr";
                if (amount >= 1000)
                    return (amount / 1000).ToString("0.#") + " K";
                return amount.ToString("#,0");
            }

            CultureInfo viVN = new CultureInfo("vi-VN");
            NumberFormatInfo nfi = viVN.NumberFormat;
            
            if (isCurrencyHidden)
                nfi.CurrencySymbol = "";
            else
                nfi.CurrencySymbol = "VND";
            
            nfi.CurrencyDecimalDigits = 0;
            return amount.ToString("C", nfi).Trim();
        }

        public static double VNCurrencyToDouble(string currency)
        { 
            //Remove all non number characters using regex
            string value = System.Text.RegularExpressions.Regex.Replace(currency, "[^0-9]", "");
            value = value.Trim();
            return double.Parse(value);
        }

        public static byte[] ImageToBytesArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image BytesArrayToImage(byte[] bytesArray)
        {
            using (MemoryStream ms = new MemoryStream(bytesArray))
            {
                return Image.FromStream(ms);
            }
        }

        public static byte[] WavToBytesArray(string path)
        {
            // Convert the wav file to bytes array for WaveFileReader to read
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] bytesArray = new byte[fs.Length];
                fs.Read(bytesArray, 0, Convert.ToInt32(fs.Length));
                return bytesArray;
            }
        }

        public static void SaveUserInfo()
        {
            if (Session.LoggedInUserInfo != null)
            {
                using (UserDbContext dbContext = new())
                {
                    // Save the user's information from session to the database
                    User? currentUser = dbContext.Users
                        .SingleOrDefault(u => u.Id == Session.LoggedInUserInfo!.Id);

                    // Update the user's information
                    if (currentUser != null)
                    {
                        dbContext.Entry(currentUser!).CurrentValues.SetValues(Session.LoggedInUserInfo);
                        dbContext.SaveChanges();
                    }
                }

                // Remove the current user from current logged in users txt file
                string currentLoggedInUsers = File.ReadAllText(@"..\..\..\Checking\CurrentLoggedInUsers.txt");
                currentLoggedInUsers = currentLoggedInUsers.Replace($"{Session.LoggedInUserInfo!.Id}\n", "");
                File.WriteAllText(@"..\..\..\Checking\CurrentLoggedInUsers.txt", currentLoggedInUsers);
            }
        }
    }
}
