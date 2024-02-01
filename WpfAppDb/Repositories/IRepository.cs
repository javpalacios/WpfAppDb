namespace WpfEmployees.Repositories;

public interface IRepository<T>
{
    List<T> GetAll();
    void Update(T entity);
}
