namespace excelParser{   


public class Candidate{ //do not think it has to be private?
    private int number;
    private string? pictureString;
    private string? name;
    private string? middlenames;
    private string? surname;
    private string? location;
    private Gender gen;
    private Race race;
    private string? university;
    private string? degree;
    private string? comments;
    private string? jobTitle;
    private Journey candJourney;

    public Candidate(int no, string picString, string fName, string sName, string loc, Gender gend, Race rc, string uni, string deg, string com , string job, Journey candJourney)
    {
        this.number = no;
        this.pictureString = picString;
        this.name = fName;
        this.surname = sName;
        this.location = loc;
        this.gen = gend;
        this.race = rc;
        this.university = uni;
        this.degree = deg;
        this.comments = com;
        this.jobTitle = job;
        this.candJourney = candJourney;
    }

        public Candidate() { 
        
                
        }


        public void printCandidate()
        {
            Console.WriteLine(string.Format("Candidate: \n \t Number: {0} \n \t Name: {1} \n" +
                "\t Surname: {2}\n \t Location: {3} \n \t Gender: {4} \n \t Race: {5} \n \t Uni: {6} \n" +
                " \t Degree {7} \n \t Comments: {8} \n \t JobTitle: {9}" , this.number, this.name, this.surname,
                this.location, this.gen, this.race, this.university, this.degree, this.comments, this.jobTitle
                ));
            candJourney.toString();
        }

        public int getNum()
        {
            return number;
        }
        public string getPictureString() 
        {
            return pictureString;
        }
        public string getName() 
        {
            return name;
        }
        public string getMiddleNames()
        {
            return middlenames;
        }

        public string getSurname()
        {
            return surname;
        }
        public string getLocation()
        {
            return location;
        }
        public Gender getGender()
        {
            return gen;
        }
        public Race getRace()
        {
            return race;
        }
        public string getUni()
        {
            return university;
        }
        public string getDeg()
        {
            return degree;
        }
        public string getComm()
        {
            return comments;
        }
        public string getJob()
        {
            return jobTitle;
        }
        public Journey getJourney()
        {
            return candJourney;
        }
}

}