namespace Presenters.Abstractions
{
    public interface IPresenter<FormatDataType>
    {
        public FormatDataType? Content { get; }
    }
}
