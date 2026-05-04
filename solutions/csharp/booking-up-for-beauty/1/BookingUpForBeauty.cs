static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var now = DateTime.Now;
        if (now < appointmentDate)
        {
            return false;
        }

        return true;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return 12 <= appointmentDate.Hour && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        var date = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");
        return $"You have an appointment on {date}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}