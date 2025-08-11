class Review
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