

public class Payment
{
    private string paymentID;
    private double amount;
    private string paymentMethod;
    private DateTime transactionDate;
    private string status;

    public string PaymentID
    {
        get { return paymentID; }
        set { paymentID = value; }
    }

    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public string PaymentMethod
    {
        get { return paymentMethod; }
        set { paymentMethod = value; }
    }

    public DateTime TransactionDate
    {
        get { return transactionDate; }
        set { transactionDate = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public Payment(string paymentID, double amount, string paymentMethod, DateTime transactionDate, string status)
    {
        this.paymentID = paymentID;
        this.amount = amount;
        this.paymentMethod = paymentMethod;
        this.transactionDate = transactionDate;
        this.status = status;
    }

    // Starts the payment process using the specified method
    public void InitiatePayment(string method)
    {
        paymentMethod = method;
        status = "Pending";
        transactionDate = DateTime.Now;
        // Additional logic to start payment can be added here
    }

    // Cancels an ongoing or pending payment by referencing its unique ID
    public void CancelPayment(string paymentID)
    {
        if (this.paymentID == paymentID && status == "Pending")
        {
            status = "Cancelled";
            // Additional logic for cancellation can be added here
        }
    }

    // Handles the actual payment transaction and updates the payment status
    public void ProcessTransaction(object details)
    {
        // Simulate transaction processing
        // In a real scenario, interact with payment gateway using 'details'
        bool transactionSuccess = true; // Simulated result

        if (transactionSuccess)
        {
            status = "Successful";
            transactionDate = DateTime.Now;
        }
        else
        {
            status = "Failed";
        }
    }

    public override string ToString()
    {
        return $"Payment ID: {PaymentID}, Amount: {Amount:C}, Method: {PaymentMethod}, Date: {TransactionDate:d}, Status: {Status}";
    }
}
