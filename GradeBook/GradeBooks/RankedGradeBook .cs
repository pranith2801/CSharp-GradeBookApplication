namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
        }

        public RankedGradeBook()
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
