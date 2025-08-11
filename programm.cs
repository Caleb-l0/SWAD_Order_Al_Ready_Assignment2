{
    public int adminId { get; set; }
    public string adminName { get; set; }
    public string adminPermissions { get; set; }

    public Administrator(int id, string name, string permissions)
    {
        adminId = id;
        adminName = name;
        adminPermissions = permissions;
    }

   

    public void manageStudentAccounts(Student student, string action)
    {
        if (action == "add")
            Console.WriteLine($"Student {student.Name} added.");
        else if (action == "update")
            Console.WriteLine($"Student {student.Name} updated.");
        else if (action == "remove")
            Console.WriteLine($"Student {student.Name} removed.");
        else
            Console.WriteLine("Invalid action.");
    }

    public void manageStaffAccount(FoodStallStaff staff, string action)
    {

        if (action == "add")
            Console.WriteLine($"Staff {staff.Name} added.");
        else if (action == "update")
            Console.WriteLine($"Staff {staff.Name} updated.");
        else if (action == "remove")
            Console.WriteLine($"Staff {staff.Name} removed.");
        else
            Console.WriteLine("Invalid action.");
    }


    public void moderateReview(Review review, string decision)
    {
        if (decision == "approve")
            Console.WriteLine($"Review {review.reviewId} approved.");
        else if (decision == "remove")
            Console.WriteLine($"Review {review.reviewId} removed.");
        else
            Console.WriteLine("Invalid decision.");
    }


    public void suspendStudent()
    {
        int noshow = 3; // placeholder//
        if (noshow >= 3)
        {
            Console.WriteLine("Student suspended due to too many no-shows.");
            
        }
        else
        {
            Console.WriteLine("No suspension needed.");
        }

    }

    public void viewAnalytics()
    {
        Console.WriteLine("Viewing analytics...");
        // Logic to view analytics would go here
    }

}   class Review
{
    public int reviewId;
    public int rating;
    public string comment;
    public bool moderated;

    public Review(int id, int rating, string comment)
    {
        this.reviewId = id;
        this.rating = rating;
        this.comment = comment;
        this.moderated = false; //placeholder//
    }

    public int GetReviewId()
    {
        return reviewId;
    }

    public int GetRating()
    {
        return rating;
    }

    public string GetComment()
    {
        return comment;
    }

    public bool IsModerated()
    {
        return moderated;
    }

    public void SetModeratedStatus(bool status)
    {
        moderated = status;
    }

    public void UpdateComment(string newComment)
    {
        comment = newComment;
    }

    public void DisplayReview()
    {
        System.Console.WriteLine("Review ID: " + reviewId);
        System.Console.WriteLine("Rating: " + rating);
        System.Console.WriteLine("Comment: " + comment);
        System.Console.WriteLine("Moderated: " + (moderated ? "Yes" : "No"));
    }
}
