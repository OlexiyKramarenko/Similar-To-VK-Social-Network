﻿using System.Collections.Generic;
using System.Linq; 
using  Core.POCO;

namespace  Core.DAL.Interfaces
{
    public interface IProfileRepository
    {
        int AttachProfileToUser(string userId, Profile profile);
        void AttachProfileToUser(Profile profile, string userId);

        string[] GetAgeYears();

        List<SelectListItem> GetBirthDay(string userId);
        string[] GetBirthDays();
        List<SelectListItem> GetBirthMonth(string userId);
        string[] GetBirthMonths();
        List<SelectListItem> GetBirthYear(string userId);
        string[] GetBirthYears(string userId);
        List<Comment> GetCommentsByStatusID(int Id);
        Profile GetContacts(string userId);
        string[] GetCountries();
        string GetCountryByUserID(string UserID);
        Profile GetCurrentProfile(string userId);
        List<string> GetEducationInfo(string userId);
        string GetEmail(string userid);
        List<SelectListItem> GetGender(string userId);
        Profile GetInterests(string userId);
        List<SelectListItem> GetLanguages(string userId);
        Profile GetMainInfo(string userId);
        List<SelectListItem> GetMaritalStatus(string userId);
        Profile GetProfile(string UserID);
        List<string> GetProfileTowns(string countryName);
        List<SelectListItem> GetSchoolCountry(string userId);
        List<SelectListItem> GetSchoolFinishYear(string userId);
        string[] GetSchoolFinishYears(string userId);
        List<SelectListItem> GetSchoolStartYear(string userId);
        string[] GetSchoolStartYears(string userId);
        List<SelectListItem> GetSchoolTown(string userId);
        List<Status> GetStatuses(string UserID);
        Education GetEducation(string userId);
        Profile GetProfileByUserId(string userId);
        void SaveContacts(Profile profile);
        void SaveEducation(Profile profile, string userId);
        void SaveInterests(Profile profile, string userId);
        void SaveMainInfo(Profile profile, string userId);
        void UpdateBirthDay(Profile profile);
        void UpdateBirthMonth(Profile profile);
        void UpdateBirthYear(Profile profile);
        void UpdateEmail(string currentUserId, string newEmail);
        
        List<Profile> GetProfiles(int from, int to, int country, int? town, string gender, IEnumerable<Profile> Profiles);
        IQueryable<Profile> GetAllProfiles();
        int[] GetAlbumIds(string userId);
        Photo GetMainPhoto(int albumId);
        PhotoAlbum GetAlbumById(int albumId);
        List<Photo> GetFirstPhotosToDisplay(int amount);
    }
}