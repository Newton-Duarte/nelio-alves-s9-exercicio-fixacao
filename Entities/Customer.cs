class Customer
{
  public string Name { get; set; }
  public string Email { get; set; }
  public string BirthDate { get; set; }

  public override string ToString()
  {
    return $"{Name}, {Email}, {BirthDate}";
  }
}