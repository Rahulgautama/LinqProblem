using System;
using System.Collections.Generic;

namespace LinqProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Problem Statement");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductId=2,UserId=1,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductId=3,UserId=2,Rating=5,Review="Good",IsLike=true},
                new ProductReview(){ProductId=4,UserId=2,Rating=4,Review="Good",IsLike=true},
                new ProductReview(){ProductId=5,UserId=3,Rating=5,Review="Nice",IsLike=false},
                new ProductReview(){ProductId=6,UserId=4,Rating=2,Review="Bad",IsLike=false},
                new ProductReview(){ProductId=1,UserId=3,Rating=1.5,Review="Nice",IsLike=false},
                new ProductReview(){ProductId=11,UserId=10,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){ProductId=12,UserId=10,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){ProductId=13,UserId=10,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){ProductId=14,UserId=10,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){ProductId=15,UserId=10,Rating=4,Review="Nice",IsLike=true},
                new ProductReview(){ProductId=16,UserId=10,Rating=4,Review="Nice",IsLike=true}
            };

            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId" + list.ProductId + " " + "UserId" + list.UserId + " " + "Rating" + list.Rating + " " + "Review" + list.Rating + " " + "IsLike" + list.IsLike);
            }
        }
    }
}
