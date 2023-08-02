public class Solution {
    public string solution(string phone_number) {
        int length = phone_number.Length;
        int maskedLength = length - 4;
        string maskedPart = new string('*', maskedLength);
        string lastFourDigits = phone_number.Substring(length - 4);

        return maskedPart + lastFourDigits;
    }
}