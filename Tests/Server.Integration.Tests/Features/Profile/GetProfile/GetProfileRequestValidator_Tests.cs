namespace GetProfileRequestValidator
{
  using FluentAssertions;
  using FluentValidation.Results;
  using FluentValidation.TestHelper;
  using MyBlazorApp.Features.Profiles;

  public class Validate_Should
  {
    private GetProfileRequestValidator GetProfileRequestValidator;

    public Validate_Should()
    {
      GetProfileRequestValidator = new GetProfileRequestValidator();
    }

    public void Be_Valid()
    {
      var getProfileRequest = new GetProfileRequest
      {
        // Set Valid values here
        // #TODO
        ProfileId = "sample"
      };

      ValidationResult validationResult = GetProfileRequestValidator.TestValidate(getProfileRequest);

      validationResult.IsValid.Should().BeTrue();
    }

    // #TODO Rename thie test and add tests for all validation rules
    public void Have_error_when_SampleProperty_is_empty() => GetProfileRequestValidator
      .ShouldHaveValidationErrorFor(aGetProfileRequest => aGetProfileRequest.ProfileId, string.Empty);

  }
}
