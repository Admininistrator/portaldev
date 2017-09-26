namespace PLEXEDC.WEB.UI.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PLEXEDC.WEB.UI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PLEXEDC.WEB.UI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.SRType.AddOrUpdate(t => t.Name,
            //new SRType { Name = "Complaint", Description = "Complaint" },
            //new SRType { Name = "Compliments", Description = "Compliments" },
            //new SRType { Name = "Enquiry", Description = "Enquiry" },
            //new SRType { Name = "Feedback", Description = "Feedback" },
            //new SRType { Name = "Request", Description = "Request" },
            //new SRType { Name = "Support", Description = "Support" }
            //);

            // context.SRArea.AddOrUpdate(a => a.Name,
            // new SRArea { Name = "ATMs", Description = "ATMs", SRTypeId = 1 },
            // new SRArea { Name = "Account", Description = "Account", SRTypeId = 1 },
            // new SRArea { Name = "Cards", Description = "Cards", SRTypeId = 1 },
            // new SRArea { Name = "Cheque", Description = "Cheque", SRTypeId = 1 },
            // new SRArea { Name = "Mobile App", Description = "Mobile App", SRTypeId = 1 },
            // new SRArea { Name = "Mobile Money", Description = "Mobile Money", SRTypeId = 1 },
            // new SRArea { Name = "POS", Description = "POS", SRTypeId = 1 },
            // new SRArea { Name = "Payments", Description = "Payments", SRTypeId = 1 },
            // new SRArea { Name = "Staff", Description = "Staff", SRTypeId = 1 },
            // new SRArea { Name = "eServices", Description = "Mobile Money", SRTypeId = 1 },

            //  // children to compliments starts here
            //  new SRArea { Name = "Cards", Description = "Cards", SRTypeId = 2 },
            //  new SRArea { Name = "Internet Banking", Description = "Internet Banking", SRTypeId = 2 },

            // //children to enquiry starts here
            // new SRArea { Name = "Account", Description = "Account", SRTypeId = 3 },
            // new SRArea { Name = "Cards", Description = "Cards", SRTypeId = 3 },
            // new SRArea { Name = "Cheque", Description = "Cheque", SRTypeId = 3 },
            // new SRArea { Name = "Internet Banking", Description = "Internet Banking", SRTypeId = 3 },
            // new SRArea { Name = "Mobile App", Description = "Mobile App", SRTypeId = 3 },

            // // children to feedback starts here
            // new SRArea { Name = "Account", Description = "Account", SRTypeId = 4 },
            // new SRArea { Name = "Cards", Description = "Cards", SRTypeId = 4 },
            // new SRArea { Name = "Cheque", Description = "Cheque", SRTypeId = 4 },
            // new SRArea { Name = "Survey", Description = "Survey", SRTypeId = 4 },

            //// children to request starts here
            //new SRArea { Name = "Account", Description = "Account", SRTypeId = 5 },
            //new SRArea { Name = "Cheque", Description = "Cheque", SRTypeId = 5 },
            //new SRArea { Name = "Internet Banking", Description = "Internet Banking", SRTypeId = 5 },
            //new SRArea { Name = "Investment", Description = "Investment", SRTypeId = 5 },
            //new SRArea { Name = "Mobile App", Description = "Mobile App", SRTypeId = 5 },
            //new SRArea { Name = "Transfers", Description = "Transfers", SRTypeId = 5 },

            //// children to support starts here
            //new SRArea { Name = "Dispute Res & Settl", Description = "Dispute Res & Settl", SRTypeId = 6 },
            //new SRArea { Name = "Fraud & Risk", Description = "Fraud & Risk", SRTypeId = 6 },
            //new SRArea { Name = "Fraud Related Resp Cod", Description = "Fraud Related Resp Cod", SRTypeId = 6 },
            //new SRArea { Name = "Maint. & Support", Description = "Maint. & Support", SRTypeId = 6 },
            //new SRArea { Name = "Maintenance", Description = "Maintenance", SRTypeId = 6 },
            //new SRArea { Name = "Transaction Support", Description = "Transaction Support", SRTypeId = 6 }

            // );

            //context.SRSubArea.AddOrUpdate(sa => sa.Name,
            //    // children to area(ATMs, complaint) starts here
            //    new SRSubArea { Name = "ATM Debit Card", Description = "ATM Debit Card", SRAreaId = 1 },
            //    new SRSubArea { Name = "ATM Wrong Debit", Description = "ATM Wrong Debit", SRAreaId = 1 },
            //    new SRSubArea { Name = "ATM Malfunction", Description = "ATM Malfunction", SRAreaId = 1 },
            //    new SRSubArea { Name = "Partial Distribution of Bills", Description = "Partial Distribution of Bills", SRAreaId = 1 },
            //    new SRSubArea { Name = "ATM Wrong Debit - Other Banks", Description = "ATM Wrong Debit - Other Banks", SRAreaId = 1 },
            //    new SRSubArea { Name = "Blocked Card", Description = "Blocked Card", SRAreaId = 1 },
            //    new SRSubArea { Name = "Online Transaction", Description = "Online Transaction", SRAreaId = 1 },

            //    // children to area(account, complaint) starts here
            //    new SRSubArea { Name = "Swift Related Fees", Description = "Swift Related Fees", SRAreaId = 2 },
            //    new SRSubArea { Name = "Transfer Related Fees", Description = "Transfer Related Fees", SRAreaId = 2 },
            //    new SRSubArea { Name = "In-correct Balance", Description = "In-correct Balance", SRAreaId = 2 },
            //    new SRSubArea { Name = "Multiple transaction charges", Description = "Multiple transaction charges", SRAreaId = 2 },
            //    new SRSubArea { Name = "Payment not reflecting", Description = "Payment not reflecting", SRAreaId = 2 },
            //    new SRSubArea { Name = "Reconciliation", Description = "Reconciliation", SRAreaId = 2 },
            //    new SRSubArea { Name = "NIBBS - (Card ops)", Description = "NIBBS - (Card ops)", SRAreaId = 2 },
            //    new SRSubArea { Name = "NEFT - (Clearing)", Description = "NEFT - (Clearing)", SRAreaId = 2 },
            //    new SRSubArea { Name = "Update customer information", Description = "Update customer information", SRAreaId = 2 },
            //    new SRSubArea { Name = "Rapid transfer", Description = "Rapid transfer", SRAreaId = 2 },
            //    new SRSubArea { Name = "Fraud", Description = "Fraud", SRAreaId = 2 },
            //    new SRSubArea { Name = "Chequebook", Description = "Chequebook", SRAreaId = 2 },
            //    new SRSubArea { Name = "Account", Description = "Account", SRAreaId = 2 },
            //    new SRSubArea { Name = "Cheque book -  (Card ops)", Description = "Cheque book", SRAreaId = 2 },
            //    new SRSubArea { Name = "Statement", Description = "Statement", SRAreaId = 2 },
            //    new SRSubArea { Name = "Dispense Error", Description = "Dispense Error", SRAreaId = 2 },
            //    new SRSubArea { Name = "Credit Related Expenses", Description = "Credit Related Expenses", SRAreaId = 2 },

            //    // children to area(cards, complaint) starts here
            //    new SRSubArea { Name = "Card Issuance", Description = "Card Issuance", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Issuance", Description = "PIN Issuance", SRAreaId = 3 },
            //    new SRSubArea { Name = "Transfer", Description = "Transfer", SRAreaId = 3 },
            //    new SRSubArea { Name = "Letter of Non indebtedness", Description = "Letter of Non indebtedness", SRAreaId = 3 },
            //    new SRSubArea { Name = "Manual Load", Description = "PManual Load", SRAreaId = 3 },
            //    new SRSubArea { Name = "Replenishment", Description = "Replenishment", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Change", Description = "PIN Change", SRAreaId = 3 },
            //    new SRSubArea { Name = "Non Receipt of Payment", Description = "Non Receipt of Payment", SRAreaId = 3 },
            //    new SRSubArea { Name = "Credit Card", Description = "Credit Card", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Captured", Description = "Card Captured", SRAreaId = 3 },
            //    new SRSubArea { Name = "Wrong Debit", Description = "Wrong Debit", SRAreaId = 3 },
            //    new SRSubArea { Name = "Chargeback", Description = "Chargeback", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Not Received", Description = "Card Not Received", SRAreaId = 3 },
            //    new SRSubArea { Name = "POS Non Functional", Description = "POS Non Functional", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Not Received", Description = "PIN Not Received", SRAreaId = 3 },
            //    new SRSubArea { Name = "Payment not Reflecting", Description = "Payment not Reflecting", SRAreaId = 3 },
            //    new SRSubArea { Name = "Transaction Declined", Description = "Transaction Declined", SRAreaId = 3 },
            //    new SRSubArea { Name = "Non Receipt of Statement", Description = "Non Receipt of Statement", SRAreaId = 3 },
            //    new SRSubArea { Name = "Deviation Amount", Description = "Deviation Amount", SRAreaId = 3 },
            //    new SRSubArea { Name = "Amount Not Debited", Description = "Amount Not Debited", SRAreaId = 3 },
            //    new SRSubArea { Name = "Update Customer Info", Description = "Update Customer Info", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Limit Increase", Description = "Card Limit Increase", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Linkage", Description = "Card Linkage", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Blockage", Description = "Card Blockage", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Unblockage", Description = "Card Unblockage", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Reset", Description = "PIN Reset", SRAreaId = 3 },
            //    new SRSubArea { Name = "Activation", Description = "Activation", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Reissue", Description = "PIN Reissue", SRAreaId = 3 },
            //    new SRSubArea { Name = "PIN Request", Description = "PIN Request", SRAreaId = 3 },
            //    new SRSubArea { Name = "Reactivation", Description = "Reactivation", SRAreaId = 3 },
            //    new SRSubArea { Name = "Reconciliation", Description = "Reconciliation", SRAreaId = 3 },
            //    new SRSubArea { Name = "State of Account", Description = "State of Account", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Reissue", Description = "Card Reissue", SRAreaId = 3 },
            //    new SRSubArea { Name = "Card Request", Description = "Card Request", SRAreaId = 3 },
            //    new SRSubArea { Name = "Account Linkage", Description = "Account Linkage", SRAreaId = 3 },
            //    new SRSubArea { Name = "Additional Card Application", Description = "Additional Card Application", SRAreaId = 3 },

            //    // children to area(cheque, complaint) starts here
            //    new SRSubArea { Name = "Cheque Remittance Ecobank Aff", Description = "Cheque Remittance Ecobank Aff", SRAreaId = 4 },
            //    new SRSubArea { Name = "Cheque Remittance Other Aff", Description = "Cheque Remittance Other Aff", SRAreaId = 4 },
            //    new SRSubArea { Name = "Cheque Remittance Country Bank", Description = "Cheque Remittance Country Bank", SRAreaId = 4 },
            //    new SRSubArea { Name = "Refer To Cheque", Description = "Refer To Cheque", SRAreaId = 4 },
            //    new SRSubArea { Name = "Opposition", Description = "Opposition", SRAreaId = 4 },
            //    new SRSubArea { Name = "No Identification Series", Description = "No Identification Series", SRAreaId = 4 },
            //    new SRSubArea { Name = "Signature Non - Compliant", Description = "Signature Non - Compliant", SRAreaId = 4 },
            //    new SRSubArea { Name = "Levy Opposition", Description = "Levy Opposition", SRAreaId = 4 },
            //    new SRSubArea { Name = "Back", Description = "Back", SRAreaId = 4 },
            //    new SRSubArea { Name = "Cheque Confirmation", Description = "Cheque Confirmation", SRAreaId = 4 },
            //    new SRSubArea { Name = "Rejected Cheque", Description = "Rejected Cheque", SRAreaId = 4 },
            //    new SRSubArea { Name = "Certified Cheque", Description = "Certified Cheque", SRAreaId = 4 },
            //    new SRSubArea { Name = "Different Amount", Description = "Different Amount", SRAreaId = 4 },

            //    // children to area(mobile app, complaint) starts here
            //    new SRSubArea { Name = "Transfer(FlexAccount - Digital)", Description = "Transfer(FlexAccount - Digital)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Others", Description = "Others", SRAreaId = 5 },
            //    new SRSubArea { Name = "Onboarding issues", Description = "Onboarding issues", SRAreaId = 5 },
            //    new SRSubArea { Name = "Delayed OTP", Description = "Delayed OTP", SRAreaId = 5 },
            //    new SRSubArea { Name = "Failed QR Transaction", Description = "Failed QR Transaction", SRAreaId = 5 },
            //    new SRSubArea { Name = "Card Services", Description = "Card Services", SRAreaId = 5 },
            //    new SRSubArea { Name = "Statement", Description = "Statement", SRAreaId = 5 },
            //    new SRSubArea { Name = "Cheque Issues", Description = "Cheque Issues", SRAreaId = 5 },
            //    new SRSubArea { Name = "Failed Bill payment", Description = "Failed Bill payment", SRAreaId = 5 },
            //    new SRSubArea { Name = "Transfer(Inter Affiliate)", Description = "Transfer(Inter Affiliate)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Transfer(Digital - FlexAccount)", Description = "Transfer(Digital - FlexAccount)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Transfer(Digital - digital)", Description = "Transfer(Digital - digital)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Transfer(IntraBank Others)", Description = "Transfer(IntraBank Others)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Transfer(IntraBank Self)", Description = "Transfer(IntraBank Self)", SRAreaId = 5 },
            //    new SRSubArea { Name = "Airtime Top-up", Description = "Airtime Top - up", SRAreaId = 5 },

            //    // children to area(mobile money, complaint) starts here
            //    new SRSubArea { Name = "Account to Phone Errors", Description = "Account to Phone Errors", SRAreaId = 6 },
            //    new SRSubArea { Name = "Phone to Account Errors", Description = "Phone to Account Errors", SRAreaId = 6 },
            //    new SRSubArea { Name = "Not Able To Transact", Description = "Not Able To Transact", SRAreaId = 6 },
            //    new SRSubArea { Name = "Delay in Refunds", Description = "Delay in Refunds", SRAreaId = 6 },

            //    // children to area(POS, complaint) starts here
            //    new SRSubArea { Name = "POS Malfunction", Description = "POS Malfunction", SRAreaId = 7 },

            //    // children to area(payment, complaint) starts here
            //    new SRSubArea { Name = "Swift Transfer", Description = "Swift Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "Standing Orders", Description = "Standing Orders", SRAreaId = 8 },
            //    new SRSubArea { Name = "Eft", Description = "Eft", SRAreaId = 8 },
            //    new SRSubArea { Name = "Salary", Description = "Salary", SRAreaId = 8 },
            //    new SRSubArea { Name = "International Transfer", Description = "International Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "Permanent Transfer", Description = "Permanent Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "Interbank Transfer", Description = "Interbank Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "Multiple Transfers", Description = "Multiple Transfers", SRAreaId = 8 },
            //    new SRSubArea { Name = "Rapid Transfer", Description = "Rapid Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "MoneyExpress", Description = "MoneyExpress", SRAreaId = 8 },
            //    new SRSubArea { Name = "MoneyGram", Description = "MoneyGram", SRAreaId = 8 },
            //    new SRSubArea { Name = "Affiliate Permanent Transfer", Description = "Affiliate Permanent Transfer", SRAreaId = 8 },
            //    new SRSubArea { Name = "Transfer Other Branch", Description = "Transfer Other Branch", SRAreaId = 8 },
            //    new SRSubArea { Name = "Transfer Same Branch", Description = "Transfer Same Branch", SRAreaId = 8 },
            //    new SRSubArea { Name = "Western Union", Description = "Western Union", SRAreaId = 8 },
            //    new SRSubArea { Name = "Wrong Debit at POS", Description = "Wrong Debit at POS", SRAreaId = 8 },

            //    // children to area(staff, complaint) starts here
            //    new SRSubArea { Name = "Staff Attitude", Description = "Staff Attitude", SRAreaId = 9 },

            //    // children to area(eservice, complaint) starts here
            //    new SRSubArea { Name = "Internet Banking", Description = "Internet Banking", SRAreaId = 10 },
            //    new SRSubArea { Name = "E - statement", Description = "E - statement", SRAreaId = 10 },
            //    new SRSubArea { Name = "E - alert", Description = "E - alert", SRAreaId = 10 },
            //    new SRSubArea { Name = "Fraud / Spam Notification", Description = "Fraud / Spam Notification", SRAreaId = 10 },
            //    new SRSubArea { Name = "SMS", Description = "SMS", SRAreaId = 10 },

            //    // children to area(cards, compliments) starts here
            //    new SRSubArea { Name = " Cards", Description = "Cards", SRAreaId = 11 },

            //    // children to area(internet bankin, compliments) starts here
            //    new SRSubArea { Name = " Internet Banking", Description = "Internet Banking", SRAreaId = 12 },

            //    // children to area(account, enquiry) starts here
            //    new SRSubArea { Name = "NIBBS - (Card ops)", Description = "NIBBS - (Card ops)", SRAreaId = 13 },
            //    new SRSubArea { Name = "Transaction Authorisation/ conf", Description = "Transaction Authorisation/ conf", SRAreaId = 13 },
            //    new SRSubArea { Name = "Account Balance", Description = "Account Balance", SRAreaId = 13 },
            //    new SRSubArea { Name = "Fees and Charges", Description = "Fees and Charges", SRAreaId = 13 },
            //    new SRSubArea { Name = "NEFT - (Clearing)", Description = "NEFT - (Clearing)", SRAreaId = 13 },
            //    new SRSubArea { Name = "Transaction History", Description = "Transaction History", SRAreaId = 13 },
            //    new SRSubArea { Name = "Transfer", Description = "Transfer", SRAreaId = 13 },
            //    new SRSubArea { Name = "Rapid transfer", Description = "Rapid transfer", SRAreaId = 13 },
            //    new SRSubArea { Name = "Swift transfer -HOFT", Description = "Swift transfer -HOFT", SRAreaId = 13 },
            //    new SRSubArea { Name = "Account Status", Description = "Account Status", SRAreaId = 13 },

            //    // children to area(cards, enquiry) starts here
            //    new SRSubArea { Name = "How to Apply", Description = "How to Apply", SRAreaId = 14 },
            //    new SRSubArea { Name = "Transaction autho./ confirmation", Description = "Transaction autho./ confirmation", SRAreaId = 14 },
            //    new SRSubArea { Name = "Transaction refund / reversal", Description = "Transaction refund / reversal", SRAreaId = 14 },
            //    new SRSubArea { Name = "Expired card", Description = "Expired card", SRAreaId = 14 },
            //    new SRSubArea { Name = "Transfer", Description = "Transfer", SRAreaId = 14 },
            //    new SRSubArea { Name = "Card Usage", Description = "Card Usage", SRAreaId = 14 },
            //    new SRSubArea { Name = "Card Status", Description = "Card Status", SRAreaId = 3 },
            //    new SRSubArea { Name = "Change Customer Details", Description = "Change Customer Details", SRAreaId = 14 },
            //    new SRSubArea { Name = "Reduction in MSC", Description = "Reduction in MSC", SRAreaId = 14 },
            //    new SRSubArea { Name = "New Merchant", Description = "New Merchant", SRAreaId = 14 },
            //    new SRSubArea { Name = "Charges Dispute", Description = "Charges Dispute", SRAreaId = 14 },
            //    new SRSubArea { Name = "Missing Payment", Description = "Missing Payment", SRAreaId = 14 },
            //    new SRSubArea { Name = "Fees and Charges", Description = "Fees and Charges", SRAreaId = 14 },
            //    new SRSubArea { Name = "Card Balance", Description = "Card Balance", SRAreaId = 14 },
            //    new SRSubArea { Name = "Cards Reports", Description = "PCards Reports", SRAreaId = 14 },
            //    new SRSubArea { Name = "Locations Accepted", Description = "Locations Accepted", SRAreaId = 14 },

            //    // children to area(cheque, enquiry) starts here
            //    new SRSubArea { Name = "Chequebook Cost", Description = "Chequebook Cost", SRAreaId = 15 },
            //    new SRSubArea { Name = "Chequebook Status", Description = "Chequebook Status", SRAreaId = 15 },
            //    new SRSubArea { Name = "Chequebook Page", Description = "Cheque Remittance Country Bank", SRAreaId = 15 },


            //    // children to area(internet banking, enquiry) starts here
            //    new SRSubArea { Name = "Username / Password", Description = "Username / Password", SRAreaId = 16 },
            //    new SRSubArea { Name = "Fees and Charges", Description = "Fees and Charges", SRAreaId = 16 },
            //    new SRSubArea { Name = "Westen Union Money Transfer", Description = "Westen Union Money Transfer", SRAreaId = 16 },
            //    new SRSubArea { Name = "How to Apply", Description = "How to Apply", SRAreaId = 16 },
            //    new SRSubArea { Name = "Transaction authorisation / conf", Description = "Transaction authorisation / conf", SRAreaId = 16 },

            //    // children to area(mobile app, enquiry) starts here
            //    new SRSubArea { Name = "Card Services", Description = "Card Services", SRAreaId = 17 },
            //    new SRSubArea { Name = "Funds Transfer", Description = "Funds Transfer", SRAreaId = 17 },
            //    new SRSubArea { Name = "Xpress Account", Description = "Xpress Account", SRAreaId = 17 },
            //    new SRSubArea { Name = "Others", Description = "Others", SRAreaId = 17 },
            //    new SRSubArea { Name = "Bill Payment", Description = "Bill Payment", SRAreaId = 17 },
            //     new SRSubArea { Name = "Onboarding", Description = "Onboarding", SRAreaId = 17 },
            //    new SRSubArea { Name = "Airtime Top-up", Description = "Airtime Top-up", SRAreaId = 17 },

            //    // children to area(account, feedback) starts here
            //    new SRSubArea { Name = "Account Status", Description = "Account Status", SRAreaId = 18 },

            //    // children to area(cards, feedback) starts here
            //    new SRSubArea { Name = "ATM Cards", Description = "ATM Cards", SRAreaId = 19 },
            //    new SRSubArea { Name = "Credit Cards", Description = "Credit Cards", SRAreaId = 19 },

            //    // children to area(cheque, feedback) starts here
            //    new SRSubArea { Name = "Returned Cheque", Description = "Returned Cheque", SRAreaId = 20 },
            //    new SRSubArea { Name = "Chequebook", Description = "Chequebook", SRAreaId = 20 },

            //    // children to area(survey, feedback) starts here
            //    new SRSubArea { Name = "Customer Survey", Description = "Customer Survey", SRAreaId = 21 },

            //    // children to area(account, request) starts here
            //    new SRSubArea { Name = "Documentation", Description = "Documentation", SRAreaId = 22 },
            //    new SRSubArea { Name = "Statement", Description = "Statement", SRAreaId = 22 },
            //    new SRSubArea { Name = "Update customer information", Description = "Update customer information", SRAreaId = 22 },
            //    new SRSubArea { Name = "Transfer Abroad", Description = "Transfer Abroad", SRAreaId = 22 },
            //    new SRSubArea { Name = "UEMOA Transfer Network Out", Description = "UEMOA Transfer Network Out", SRAreaId = 22 },
            //    new SRSubArea { Name = "Ecobank Transfer Network UEMOA", Description = "Ecobank Transfer Network UEMOA", SRAreaId = 22 },
            //    new SRSubArea { Name = "Transfer Network Exclude UEMOA", Description = "Transfer Network Exclude UEMOA", SRAreaId = 22 },
            //    new SRSubArea { Name = "Ecobank Transfer Network", Description = "Ecobank Transfer Network", SRAreaId = 22 },
            //    new SRSubArea { Name = "Currency Transfer Outside UEMOA", Description = "Currency Transfer Outside UEMOA", SRAreaId = 22 },
            //    new SRSubArea { Name = "Aggio Ticket(Comms, Products)", Description = "Aggio Ticket(Comms, Products)", SRAreaId = 22 },
            //    new SRSubArea { Name = "Swift", Description = "Swift", SRAreaId = 22 },
            //    new SRSubArea { Name = "Special Visa statement", Description = "Special Visa statement", SRAreaId = 22 },
            //    new SRSubArea { Name = "Simple Statement", Description = "Simple Statement", SRAreaId = 22 },
            //    new SRSubArea { Name = "Ecobank Rapid Transfer", Description = "Ecobank Rapid Transfer", SRAreaId = 22 },
            //    new SRSubArea { Name = "Ordinary Personal Loan", Description = "Ordinary Personal Loan", SRAreaId = 22 },
            //    new SRSubArea { Name = "Mortgage", Description = "Mortgage", SRAreaId = 22 },
            //    new SRSubArea { Name = "Open an Account", Description = "Open an Account", SRAreaId = 22 },
            //    new SRSubArea { Name = "Interest Scale", Description = "Interest Scale", SRAreaId = 22 },
            //    new SRSubArea { Name = "Reactivation Dormant Account", Description = "Reactivation Dormant Account", SRAreaId = 22 },
            //    new SRSubArea { Name = "Mandate Update", Description = "Mandate Update", SRAreaId = 22 },
            //    new SRSubArea { Name = "Stop Cheque", Description = "Stop Cheque", SRAreaId = 22 },
            //    new SRSubArea { Name = "Disbursement", Description = "Disbursement", SRAreaId = 22 },
            //    new SRSubArea { Name = "Audit Confirmation", Description = "Audit Confirmation", SRAreaId = 22 },
            //    new SRSubArea { Name = "Activation", Description = "Activation", SRAreaId = 22 },
            //    new SRSubArea { Name = "Close Account", Description = "Close Account", SRAreaId = 22 },
            //    new SRSubArea { Name = "Other", Description = "Other", SRAreaId = 22 },
            //    new SRSubArea { Name = "Fundraising", Description = "Fundraising", SRAreaId = 22 },
            //    new SRSubArea { Name = "Certificate(Balance, RIB)", Description = "Certificate(Balance, RIB)", SRAreaId = 22 },
            //    new SRSubArea { Name = "Certificate of DAT", Description = "Certificate of DAT", SRAreaId = 22 },
            //    new SRSubArea { Name = "Notice of Credit / Debit", Description = "Notice of Credit / Debit", SRAreaId = 22 },
            //    new SRSubArea { Name = "Cash Voucher", Description = "Cash Voucher", SRAreaId = 22 },
            //    new SRSubArea { Name = "Bank Guarantee", Description = "Bank Guarantee", SRAreaId = 22 },
            //    new SRSubArea { Name = "Cheque Copy", Description = "Cheque Copy", SRAreaId = 22 },
            //    new SRSubArea { Name = "Overdraft", Description = "Overdraft", SRAreaId = 22 },
            //    new SRSubArea { Name = "Request Authentication", Description = "Request Authentication", SRAreaId = 22 },
            //    new SRSubArea { Name = "Term Deposit", Description = "Term Deposit", SRAreaId = 22 },

            //    // children to area(cheque, request) starts here
            //    new SRSubArea { Name = " Opposition", Description = " Opposition", SRAreaId = 23 },
            //    new SRSubArea { Name = "Levy Opposition", Description = "Levy Opposition", SRAreaId = 23 },

            //    // children to area(internet banking, request) starts here
            //    new SRSubArea { Name = "Activation Payment Option", Description = "Activation Payment Option", SRAreaId = 24 },
            //    new SRSubArea { Name = "Deactivation", Description = "Fees and Charges", SRAreaId = 24 },
            //    new SRSubArea { Name = "Activation", Description = "Activation", SRAreaId = 24 },
            //    new SRSubArea { Name = "User Modification", Description = "User Modification", SRAreaId = 24 },
            //    new SRSubArea { Name = "User Creation", Description = "User Creation", SRAreaId = 24 },
            //    new SRSubArea { Name = "Unlocking", Description = "Unlocking", SRAreaId = 24 },
            //    new SRSubArea { Name = "Locking", Description = "Locking", SRAreaId = 24 },
            //    new SRSubArea { Name = "Password Reset", Description = "Password Reset", SRAreaId = 24 },
            //    new SRSubArea { Name = "Account Addition", Description = "Account Addition", SRAreaId = 24 },
            //    new SRSubArea { Name = "Customer Feedback", Description = "Customer Feedback", SRAreaId = 24 },
            //    new SRSubArea { Name = "Registration", Description = "Registration", SRAreaId = 24 },


            //    // children to area(investment, request) starts here
            //    new SRSubArea { Name = "Call Investment", Description = "Call Investment", SRAreaId = 25 },
            //    new SRSubArea { Name = "Treasury Bill", Description = "Treasury Bill", SRAreaId = 25 },
            //    new SRSubArea { Name = "Fixed Deposit", Description = "Fixed Deposit", SRAreaId = 25 },
            //    new SRSubArea { Name = "Liquidation", Description = "Liquidation", SRAreaId = 25 },

            //    // children to area(mobile app, request) starts here
            //    new SRSubArea { Name = "Limit Change", Description = "Limit Change", SRAreaId = 26 },
            //    new SRSubArea { Name = "Delete", Description = "Delete", SRAreaId = 26 },
            //    new SRSubArea { Name = "PIN Reset", Description = "PIN Reset", SRAreaId = 26 },
            //    new SRSubArea { Name = "Lock", Description = "Lock", SRAreaId = 26 },
            //    new SRSubArea { Name = "Unlock", Description = "Unlock", SRAreaId = 26 },
            //    new SRSubArea { Name = "Add Account", Description = "Add Account", SRAreaId = 26 },

            //    // children to area(transfer, request) starts here
            //    new SRSubArea { Name = "Trade Transfers", Description = "Trade Transfers", SRAreaId = 27 },
            //    new SRSubArea { Name = "Salary", Description = "Salary", SRAreaId = 27 },
            //    new SRSubArea { Name = "Interbank Transfers", Description = "Interbank Transfers", SRAreaId = 27 },
            //    new SRSubArea { Name = "Outward Transfer", Description = "Outward Transfer", SRAreaId = 27 },
            //    new SRSubArea { Name = "Standing Order", Description = "Standing Order", SRAreaId = 27 },
            //    new SRSubArea { Name = "Internal Transfer", Description = "Internal Transfer", SRAreaId = 27 },
            //    new SRSubArea { Name = "FX Conversion", Description = "FX Conversion", SRAreaId = 27 },

            //    // children to area(Dispute Res & Settl, support) starts here
            //    new SRSubArea { Name = " VISA Card", Description = " VISA Card", SRAreaId = 28 },

            //    // children to area(Fraud & Risk, support) starts here
            //    new SRSubArea { Name = "Suspicious Transaction Alerts", Description = "Suspicious Transaction Alerts", SRAreaId = 29 },

            //    // children to area(Fraud Related Resp Cod, support) starts here
            //    new SRSubArea { Name = "Card Unblocking", Description = "Card Unblocking", SRAreaId = 30 },
            //    new SRSubArea { Name = "Card Blocking", Description = "Card Blocking", SRAreaId = 30 },

            //    // children to area(Maint. & Support, support) starts here
            //    new SRSubArea { Name = "Currency Report Upload", Description = "Currency Report Upload", SRAreaId = 31 },
            //    new SRSubArea { Name = "POS Transaction Analysis", Description = "POS Transaction Analysis", SRAreaId = 31 },
            //    new SRSubArea { Name = "Daily Suspect Transaction", Description = "Daily Suspect Transaction", SRAreaId = 31 },

            //    // children to area(Maintenance, support) starts here
            //    new SRSubArea { Name = "Card Account Linkage", Description = "Card Account Linkage", SRAreaId = 32 },
            //    new SRSubArea { Name = "Card Unblocking", Description = "Card Unblocking", SRAreaId = 32 },
            //    new SRSubArea { Name = "Card Limit Change", Description = "Card Limit Change", SRAreaId = 32 },
            //    new SRSubArea { Name = "Card Blocking", Description = "Card Blocking", SRAreaId = 32 },
            //    new SRSubArea { Name = "PIN Reset", Description = "PIN Reset", SRAreaId = 32 },

            //    // children to area(Transaction Support, support) starts here
            //    new SRSubArea { Name = "Failed Card Txn Investigation", Description = "Failed Card Txn Investigation", SRAreaId = 30 },
            //    new SRSubArea { Name = "ATM Transaction Analysis", Description = "ATM Transaction Analysis", SRAreaId = 30 }
            //    );

            //context.SRStatus.AddOrUpdate(s => s.Name,
            //   new SRStatus { Name = "Not Started", Description = "Not Started" },
            //   new SRStatus { Name = "In Progress", Description = "In Progress" },
            //   new SRStatus { Name = "Escalated", Description = "Escalated" },
            //   new SRStatus { Name = "Open", Description = "Open" },
            //   new SRStatus { Name = "Closed", Description = "Closed" },
            //   new SRStatus { Name = "Obsolete", Description = "Obsolete" },
            //   new SRStatus { Name = "Submitted for Approval", Description = "Submitted for Approval" },
            //   new SRStatus { Name = "Reviewed with Comments", Description = "Reviewed with Comments" },
            //   new SRStatus { Name = "Re-Opened", Description = "Re-Opened" },
            //   new SRStatus { Name = "Awaiting Customer", Description = "Awaiting Customer" },
            //   new SRStatus { Name = "For Review", Description = "For Review" },
            //   new SRStatus { Name = "Updated", Description = "Updated" },
            //   new SRStatus { Name = "Reassigned", Description = "Reassigned" }

            //);

            //context.SRSubStatus.AddOrUpdate(ss => ss.Name,
            //   new SRSubStatus { Name = "Unassigned", Description = "Unassigned" },
            //   new SRSubStatus { Name = "Waiting on Customer", Description = "Waiting on Customer" },
            //   new SRSubStatus { Name = "Resolved", Description = "Resolved" },
            //   new SRSubStatus { Name = "Assigned", Description = "Assigned" },
            //   new SRSubStatus { Name = "Follow Up", Description = "Follow Up" },
            //   new SRSubStatus { Name = "Escalated", Description = "Escalated" }

            //   );
            //context.SRPriority.AddOrUpdate(p => p.Name,
            //    new SRPriority { Name = "1-ASAP", Description = "1-ASAP" },
            //    new SRPriority { Name = "2-High", Description = "2-High" },
            //    new SRPriority { Name = "3-Medium", Description = "3-Medium" },
            //    new SRPriority { Name = "4-Low", Description = "4-Low" }
            //    );
        }
    }
}
