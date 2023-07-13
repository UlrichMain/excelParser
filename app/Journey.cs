using System;

public class Journey
{
	private Status stat;
	private Gender gen;
	private OpenDay OD;
	private string comments;
	private DateTime date;

	public Journey(Status stat, Gender gen, OpenDay OD, string comments, DateTime date)
	{
		this.stat = stat;
		this.gen = gen;
		this.OD = OD;
		this.comments = comments;
		this.date = date;
	}

	public void toString()
	{
		Console.WriteLine(string.Format("Candidate Journey:\nStatus: {0} |Gender: {1} |OpenDay: {2} |Date: {3} " +
			"\nComments:{4}", this.stat, this.gen, this.OD, this.date, this.comments));
	}

	public Status getStat()
	{
		return stat;
	}

	public Gender getGen()
	{
		return gen;
	}

	public OpenDay getOD()
	{
		return OD;
	}

	public string getCom()
	{
		return comments;
	}

	public DateTime getDate()
	{
		return date;
	}

    public void setStat(Status up)
    {
        this.stat = up;
    }

    public void setGen(Gender up)
    {
        this.gen = up;
    }

    public void setOD(OpenDay up)
    {
        this.OD = up;
    }

    public void setCom(string up)
    {
        this.comments = up;
    }

    public void setDate(DateTime up)
    {
        this.date = up;
    }
}
