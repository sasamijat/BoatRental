using BigGame.Models.Context;
using BIgGameCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class ImageController : Controller
{
    private readonly IWebHostEnvironment _hostEnvironment;
    private IWebHostEnvironment _webHostEnvironment;

    public ImageController(IWebHostEnvironment hostEnvironment)
    {
        this._webHostEnvironment = hostEnvironment;
    }
    public IActionResult Index()
    {
        using (var context = new BigGameContext())
        {

            return View(context.Images.ToList());
        }
    }

    [HttpPost]
    public void addNew(ImageModel imageModel)
    {
        if (ModelState.IsValid)
        {
            string uniqueFileName = null;
            if (imageModel.Attachment != null)
            {
                string[] file = imageModel.Attachment.Split(',');
                imageModel.ImageFile = LoadImage(file[1], imageModel.ImageName);
                uniqueFileName = UploadedFile(imageModel.ImageFile, "images");
            }

            addNewImage(imageModel, uniqueFileName);
        }



    }

    [HttpPost]
    public void addNewProfileImage(int id,ImageModel imageModel) {
        if (ModelState.IsValid)
        {
            if (imageModel.Attachment != null)
            {
                string uniqueFileName = null;
                string[] file = imageModel.Attachment.Split(',');
                imageModel.ImageFile = LoadImage(file[1], imageModel.ImageName);
                uniqueFileName = UploadedFile(imageModel.ImageFile, "images/users");

                addNewUserProfileImage(id, uniqueFileName);
            }



        }

    }
    [HttpPost]
    public void addNewBoatImage(int id, ImageModel imageModel)
    {
        if (ModelState.IsValid)
        {
            if (imageModel.Attachment != null)
            {
                string uniqueFileName = null;
                string[] file = imageModel.Attachment.Split(',');
                imageModel.ImageFile = LoadImage(file[1], imageModel.ImageName);
                uniqueFileName = UploadedFile(imageModel.ImageFile, "images/boats");

                addNewBoatImageDB(id, uniqueFileName);
            }



        }

    }
    public IFormFile LoadImage(string file, string imageName)
    {
        //data:image/gif;base64,
        //this image is a single pixel (black)
        byte[] bytes = Convert.FromBase64String(file);

        IFormFile commentImage;
        MemoryStream ms = new MemoryStream(bytes);

        commentImage = new FormFile(ms, 0, bytes.Length, "imageString", imageName);


        return commentImage;
    }
    private string UploadedFile(IFormFile image, string? folder)
    {
        if (folder == null)
            folder = "images";
        string uniqueFileName = null;

        if (image != null)
        {
            string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);
            uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            var fileStream = new FileStream(filePath, FileMode.Create);

            image.CopyTo(fileStream);
            fileStream.Close();

        }
        return uniqueFileName;
    }

    private void addNewImage(ImageModel imageModel,string? uniqueName) {

        ImageModel image = new ImageModel(imageModel);
        image.Attachment = uniqueName;
        using (var context = new BigGameContext()) {
            context.Images.Add(image);
            context.SaveChanges();
        }
    }

    private void addNewUserProfileImage(int userId, string uniqueName)
    {

        using (var context = new BigGameContext())
        {
            context.Users.Where(u => u.UserID == userId).FirstOrDefault().ProfileImage = uniqueName;
            context.SaveChanges();
        }
    }

    private void addNewBoatImageDB(int boatId, string uniqueName)
    {

        using (var context = new BigGameContext())
        {
            BoatImage boatImage = new BoatImage { Image = uniqueName, BoatId = boatId };

            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.BoatImages ON;");
            context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Boats ON;");

            context.BoatImages.Add(boatImage);
            context.Boats.Include(b => b.BoatImages).Where(b => b.BoatID == boatId).FirstOrDefault().BoatImages.Add(boatImage);
            
            context.SaveChanges();
        }
    }

}