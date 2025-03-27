namespace MythicArena.Components
{
    public interface IPicsumService
    {
        public Task<string> GetRandomImageUrl();


        public Task<string> GetRandomImageWithSize(int width, int height);


    }
}
