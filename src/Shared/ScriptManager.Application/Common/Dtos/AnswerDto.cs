namespace ScriptManager.Application.Common.Dtos
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string? JumpToQuestion { get; set; }
    }
}