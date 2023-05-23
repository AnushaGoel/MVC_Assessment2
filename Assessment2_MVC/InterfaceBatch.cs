using Assessment2_MVC.Models;

namespace Assessment2_MVC
{
    public interface InterfaceBatch
    {
        List<BatchViewModel> GetBatches();
        Batch Create(Batch batch);
        Batch GetBatchById(int id);
        int Edit(int id, Batch batch);
        int Delete(int id);

    }
}
