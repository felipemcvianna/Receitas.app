namespace LivroReceitas.Exceptions.ExceptionsBase;

public class ErrorOnValidateExceptions : MeuLivroReceitasExceptions
{
    public List<string> ErrorsMessages { get; set; }

    public ErrorOnValidateExceptions(List<string> errorsMessages)
    {
        ErrorsMessages = errorsMessages;
    }

    public ErrorOnValidateExceptions(string error)
    {
        ErrorsMessages = new List<string>()
        {
            error
        };
    }
    
}