namespace excelParser{   


public class Candidate{ //do not think it has to be private?
    public string? number;
    public string? pictureString;
    public string? name;
    public string? middlenames;
    public string? surname;
    public string? location;
    public string? gender;
    public string? race;
    public string? university;
    public string? degree;
    public string? comments;
    public string? jobTitle;

    public Candidate(string no, string picString, string fName, string sName, string loc, string gend, string rc, string uni, string deg, string com , string job)
    {
        this.number = no;
        this.pictureString = picString;
        this.name = fName;
        this.surname = sName;
        this.location = loc;
        this.gender = gend;
        this.race = rc;
        this.university = uni;
        this.degree = deg;
        this.comments = com;
        this.jobTitle = job;
    }

        public Candidate() { 
        
                
        }


        public void printCandidate()
        {
            Console.WriteLine(string.Format("Candidate: \n \t Number: {0} \n \t Name: {1} \n" +
                "\t Surname: {2}\n \t Location: {3} \n \t Gender: {4} \n \t Race: {5} \n \t Uni: {6} \n" +
                " \t Degree {7} \n \t Comments: {8} \n \t JobTitle: {9}" , this.number, this.name, this.surname,
                this.location, this.gender, this.race, this.university, this.degree, this.comments, this.jobTitle
                ));
        }
}

}