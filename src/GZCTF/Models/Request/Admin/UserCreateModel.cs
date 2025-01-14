﻿using System.ComponentModel.DataAnnotations;

namespace GZCTF.Models.Request.Admin;

/// <summary>
/// 批量用户创建（Admin）
/// </summary>
public class UserCreateModel
{
    /// <summary>
    /// 用户名
    /// </summary>
    [Required(ErrorMessageResourceName = nameof(Resources.Program.Model_UserNameRequired),
        ErrorMessageResourceType = typeof(Resources.Program))]
    [MinLength(3, ErrorMessageResourceName = nameof(Resources.Program.Model_UserNameTooShort),
        ErrorMessageResourceType = typeof(Resources.Program))]
    [MaxLength(15, ErrorMessageResourceName = nameof(Resources.Program.Model_UserNameTooLong),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// 密码
    /// </summary>
    [Required(ErrorMessageResourceName = nameof(Resources.Program.Model_PasswordRequired),
        ErrorMessageResourceType = typeof(Resources.Program))]
    [MinLength(6, ErrorMessageResourceName = nameof(Resources.Program.Model_PasswordTooShort),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// 邮箱
    /// </summary>
    [Required(ErrorMessageResourceName = nameof(Resources.Program.Model_EmailRequired),
        ErrorMessageResourceType = typeof(Resources.Program))]
    [EmailAddress(ErrorMessageResourceName = nameof(Resources.Program.Model_EmailMalformed),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// 真实姓名
    /// </summary>
    [MaxLength(7, ErrorMessageResourceName = nameof(Resources.Program.Model_RealNameTooLong),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string? RealName { get; set; }

    /// <summary>
    /// 学号
    /// </summary>
    [MaxLength(24, ErrorMessageResourceName = nameof(Resources.Program.Model_StdNumberTooLong),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string? StdNumber { get; set; }

    /// <summary>
    /// 联系电话
    /// </summary>
    [Phone(ErrorMessageResourceName = nameof(Resources.Program.Model_MalformedPhoneNumber),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string? Phone { get; set; }

    /// <summary>
    /// 用户加入的队伍
    /// </summary>
    [MaxLength(15, ErrorMessageResourceName = nameof(Resources.Program.Model_TeamNameTooLong),
        ErrorMessageResourceType = typeof(Resources.Program))]
    public string? TeamName { get; set; }

    internal UserInfo ToUserInfo() =>
        new()
        {
            Email = Email,
            UserName = UserName,
            RealName = RealName ?? "",
            StdNumber = StdNumber ?? "",
            PhoneNumber = Phone,
            EmailConfirmed = true
        };
}