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
        number = no;
        pictureString = picString;
        name = fName;
        surname = sName;
        location = loc;
        gender = gend;
        race = rc;
        university = uni;
        degree = deg;
        comments = com;
        jobTitle = job;
    }
}

    

}