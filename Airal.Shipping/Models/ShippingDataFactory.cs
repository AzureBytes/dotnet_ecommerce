using System;
using System.Linq;
using System.Text;

namespace Airal.Shipping.Models
{
    public static class ShippingDataFactory
    {
        private static Random _rand = new Random();

        public static ShippingData GetData()
        {
            return new ShippingData
            {
                Shipper = "UPS",
                TrackingCode = GetRandomTrackingCode()
            };
        }

        private static string GetRandomTrackingCode()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("1Z");
            builder.Append(RandomAlphaNumeric(6));
            builder.Append("03");
            builder.Append(RandomNumeric(8));

            return builder.ToString();
        }

        private static string RandomAlphaNumeric(int size)
        {
            return RandomString("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", size);
        }

        private static string RandomNumeric(int size)
        {
            return RandomString("0123456789", size);
        }

        private static string RandomString(string input, int size)
        {
            var chars = Enumerable.Range(0, size).Select(x => input[_rand.Next(0, input.Length)]);
            return new string(chars.ToArray());
        }
    }
}