namespace Lesson10
{
    class People
    {
        string name;
        int age;
        string secondName;
        string middleName;
        string phoneNumber;
        Reader reader;
        Worker worker;

        public People(string name, int age, string secondName, string middleName, string phoneNumber)
        {
            this.age = age;
            this.secondName = secondName;
            this.middleName = middleName;
            this.phoneNumber = phoneNumber;

            this.name = name;

        }
        public People(string name, int age, string secondName, string middleName, string phoneNumber, Worker worker)
        {
            this.age = age;
            this.secondName = secondName;
            this.middleName = middleName;
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.worker = worker;
        }
        public People()
        {

        }
        public People(string name, int age, string secondName, string middleName, string phoneNumber, Reader reader)
        {
            this.age = age;
            this.secondName = secondName;
            this.middleName = middleName;
            this.phoneNumber = phoneNumber;
            this.name = name;
            this.reader = reader;
        }

    }
}

