using Assessment2_MVC.Context;
using Assessment2_MVC.Models;

namespace Assessment2_MVC.Repository
{
    public class BatchRepository : InterfaceBatch
    {
        TrainingDbContext ___db;

        public BatchRepository(TrainingDbContext db2)
        {
            ___db = db2;
        }

        public Batch GetBatchById(int id)
        {
            return ___db.Batches.FirstOrDefault(x => x.BatchId == id);
        }

        public List<BatchViewModel> GetBatches()
        {
            var list = (
                from batch in ___db.Batches
                join course in ___db.Courses on batch.Course.CourseId
                equals course.CourseId
                select new BatchViewModel
                {
                    Id = batch.BatchId,
                    BatchName = batch.BatchName,
                    Trainer = batch.Trainer,
                    CourseName = course.CourseName,
                    Description = course.Description,
                    StartDate = batch.StartDate,
                }).ToList();
            return list;
        }
    
    
        public Batch Create(Batch batch)
        {
            ___db.Batches.Add(batch);
            ___db.SaveChanges();
            return batch;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Edit(int id, Batch batch)
        {
            Batch obj = GetBatchById(id);
            if(obj!=null)
            {
                foreach(Batch temp in ___db.Batches)
                {
                    if(temp.BatchId==id)
                    {
                        temp.BatchName = batch.BatchName;
                        temp.Trainer=batch.Trainer;
                        temp.StartDate=batch.StartDate;

                    }
                }
                ___db.SaveChanges() ;
                return 0;
            }
            else
            {
                return 1;
            }
        }

       
    }
}
