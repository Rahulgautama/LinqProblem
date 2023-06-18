using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqProblem
{
    class Management
    {
        public void TopRecords(List<ProductReview> listProductReviews)
        {
            var recordsData = (from ProductReview in listProductReviews orderby ProductReview.Rating descending select ProductReview).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductId " + list.ProductId + " " + "UserId " + list.UserId + " " + "Rating " + list.Rating + " " + "Review " + list.Rating + " " + "IsLike " + list.IsLike);
            }
        }
        public void SelectRecords(List<ProductReview> listProductReviews)
        {
            var recordsData = from productReview in listProductReviews where (productReview.ProductId == 1 || productReview.ProductId == 4 || productReview.ProductId == 9) && productReview.Rating > 3 select productReview;

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductId " + list.ProductId + " " + "UserId " + list.UserId + " " + "Rating " + list.Rating + " " + "Review " + list.Rating + " " + "IsLike " + list.IsLike);
            }

        }
        public void RetriveCountOfRecords(List<ProductReview> listProductReviews)
        {
            var recordsData = listProductReviews.GroupBy(x => x.ProductId).Select(x => new { ProductID = x.Key, Count = x.Count() });

            foreach (var list in recordsData)
            {
                Console.WriteLine(list.ProductID + "------" + list.Count);
            }
        }
    }
}
