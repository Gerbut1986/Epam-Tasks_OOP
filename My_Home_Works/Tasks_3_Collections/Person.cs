namespace Tasks_3_Collections
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public System.Collections.Generic.IEnumerable<string> PhoneNumbers { get; set; }

        public System.Collections.Generic.IEnumerable<string> GetPhones()
        {
            foreach (string number in PhoneNumbers)
                yield return number;
        }
    }
}
