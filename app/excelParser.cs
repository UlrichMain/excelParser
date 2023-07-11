
using System.Reflection;

namespace excelParser{

    class Parser
    {
        Candidate[] candidates;


        public void getCandidates()
        {
            string path = "C:\Users\USER\Downloads\ExcelParser.csv";
            StreamReader strRead = null;
            if (File.exists(path))
            {
                strRead = new SreamReader(File.openRead(path));
                List<string> clientVals = new List<string>();
                var headers = strRead.ReadLine();

                string cID = cVals[0];
                string pictureString = cVals[1];
                string name;
                string surname;
                string gender;
                string race;
                string university;
                string degree;
                string comments;
                string jobTitle;

                while (!strRead.EndOfStream)
                {
                   

                    var cLine = strRead.ReadLine();
                    var cVals = cLine.Split(',');

                    

                    if (cVals[2].Contains(" and "))
                    {
                        string full = cVals[2];
                        var nVals = full.Split(" and ");
                        name = nVals[0];
                        surname = nVals[1];
                        gender = cVals[3];
                        race = cVals[4];
                        university = cVals[5];
                        degree = cVals[6];
   
                        for (int i = 7; i < cVals.Length - 1; i++)
                        {
                            comments = comments + cVals[i]
                        }
                        
                    }

                    else
                    {
                        name = cVals[2];
                        surname = cVals[3];
                        gender = cVals[4];
                        race = cVals[5];
                        university = cVals[6];
                         degree = cVals[7];
                        
                        for (int i = 8; i < cVals.Length - 1; i++)
                        {
                            comments = comments + cVals[i]
                        }
                    
                    }

                    string jobTitle = cVals[cVals.Length - 1];
                    Candidate temp = new Candidate(cID, pictureString, name, surname, gender, race, university, degree, comments, jobTitle);

                }
            }
        }



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