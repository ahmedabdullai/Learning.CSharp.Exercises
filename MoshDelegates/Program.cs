


using MoshDelegates;

var filters = new PhotoFilters();

//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilter;

new PhotoProcessor().Process("photo.jpg", filterHandler);



static void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Red eye removed");
}