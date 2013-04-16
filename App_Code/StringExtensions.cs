using System;

/// <summary>
/// Utility string methods
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Returns the string or DBNull.Value if it is empty
    /// </summary>
    /// <param name="s">The string to act on</param>
    /// <returns>Object</returns>
	public static object OrDbNull(this string s) {
	    return string.IsNullOrEmpty(s) ? DBNull.Value : (object) s;
	}

    /// <summary>
    /// Tests to see if a string has a value of "on"
    /// </summary>
    /// <param name="s">The string to test</param>
    /// <returns>Boolean</returns>
    public static bool IsOn(this string s) {
        return !string.IsNullOrEmpty(s) && s.Equals("on");
    }
}