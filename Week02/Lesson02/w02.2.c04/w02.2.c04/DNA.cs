public class DNA
{
    public string Seq;
    
    public DNA(string Seq)
    {
        this.Seq = Seq;
    }

    public DNA Replicate1()
    {
        DNA newDna = new DNA(Seq);
        return newDna;
    }

    public DNA Replicate2()
    {
        return this;
    }

    public void Mutate(string newSeq)
    {
        Seq = newSeq;
    }
}