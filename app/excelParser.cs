
using System.Reflection;

namespace excelParser{

    class Parser
    {
        Candidate[] candidates;


        static void Main(string[] args)
        {
            Candidate candidate = new Candidate();
            candidate.number = "1";
            candidate.pictureString = "1232";
            candidate.name = "Jessica";
            candidate.surname = "Parker";
            candidate.location = "Sandton";
            candidate.gender = "Other";
            candidate.race = "White";
            candidate.university = "University of Johannesburg";
            candidate.degree = "Bsc in Computer Science";
            candidate.comments = "hard working mfer";
            candidate.jobTitle = "Software Engineer";

            noNullValues(candidate);
        }


        static Boolean isValidCandiate(Candidate candidate)
        {
            return true;
        }

        static Boolean noNullValues(Candidate candidate)
        {
        }

        static Boolean isValidNumber(string number)
        {
            return true;
        }

        static Boolean isValidPicture(string picture)
        {
            return true;
        }

        static Boolean isValidName(string name)
        {
            return true;
        }

        static Boolean isValidLocation(string location)
        {
            return true;
        }

        static Boolean isValidGender(string gender)
        {
            return true;
        }


        static Boolean isValidUniversity(string university)
        {
            return true;
        }

        static Boolean isValidDegree(string degree)
        {
            return true;
        }


        static Boolean isValidComment(string comment)
        {
            return true;
        }

        static Boolean isValidJobTitle(string job)
        {
            return true;
        }



    }



    


}