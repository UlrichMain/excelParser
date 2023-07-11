namespace excelParser{   
class Client{
    long id;
    string pictureString;
    string name;
    string surname;
    int gender;
    string race;
    string university;
    string degree;
    string comments;
    string jobTitle;

        public Client(long tID, string cPic, string fName, string sName, int cGen, string cRace, string uni, string cDeg, string com, string cJob)
        {
            id = tID;
            pictureString = cPic;
            name = fName;
            surname = sName;
            gender = cGen;
            race = cRace;
            university = uni;
            degree = deg;
            comments = com;
            jobTitle = cJob;
        }

        public toString()
        {
            Console.print("TestData");
        }
}

}