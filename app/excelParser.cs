using Candidate;

namespace excelParser {

    Candidate[] candidates;
    Candidate temp = new Candidate();

    public void getClients()
    {
        string path = "C:\Users\USER\Downloads\ExcelParser.csv";
        StreamReader strRead = null;
        if (File.exists(path))
        {
            strRead = new SreamReader(File.openRead(path));
            List<string> clientVals = new List<string>();
            var headers = strRead.ReadLine();
            var heads = headers.Split(',');
            Console.print("No: Headers: " + heads.Length);
            while (!strRead.EndOfStream)
            {
                var cLine = strRead.ReadLine();
                List<string> cVals = cLine.Split(',');
                long cID = cVals[0];
                string pictureString = cVals[1];
                string name = cVals[2];
                string surname = cVals[3];
                int gender = cVals[4];
                string race = cVals[5];
                string university = cVals[6];
                string degree = cVals[7];
                string comments;
                for(int i = 8; i<cVals.Length-1;i++)
                {
                    comments = comments + cVals[i]
                }
                string jobTitle = cVals[cVals.Length-1];
                 
                Candidate temp = new Candidate();


            }

        }



    }


}