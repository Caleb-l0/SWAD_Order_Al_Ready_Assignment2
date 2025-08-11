class Administrator
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

    public void manageAccounts()
    {

    }



    public void manageStudentAccounts(Student student, string action)
    {
        manageAccounts();
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
        manageAccounts();
        if (action == "add")
            Console.WriteLine($"Staff {staff.Name} added.");
        else if (action == "update")
            Console.WriteLine($"Staff {staff.Name} updated.");
        else if (action == "remove")
            Console.WriteLine($"Staff {staff.Name} removed.");
        else
            Console.WriteLine("Invalid action.");
    }


    public void moderateReview(Review review)
    {
        if (review.moderated)
        {
            Console.WriteLine("Review already handled.");
            return;
        }

        Console.WriteLine("Choose action: 1=Approve, 2=Delete, 3=False Report");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            review.moderated = true;
            Console.WriteLine("Review approved.");
        }

        else if (choice == 2)
        {
            review.comment = "[Removed by Admin]";
            review.moderated = true;
            Console.WriteLine("Review deleted.");
        }
        else if (choice == 3)
        {
            Console.WriteLine("False report logged. Warning sent to staff.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Action logged for Review ID: " + review.reviewId);
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

}