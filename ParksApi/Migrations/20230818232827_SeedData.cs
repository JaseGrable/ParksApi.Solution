using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Description", "Name", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes.", "Acadia National Park", "Maine", "National" },
                    { 2, "The southernmost national park is on three Samoan islands in the South Pacific. It protects coral reefs, rainforests, volcanic mountains, and white beaches.", "American Samoa", "American Samoa", "National" },
                    { 3, "This site features more than 2,000 natural sandstone arches.", "Arches National Park", "Utah", "National" },
                    { 4, "They contain the largest known assemblage of late Eocene and Oligocene mammal fossils.", "Badlands National Park", "South Dakota", "National" },
                    { 5, "Its main attraction is backcountry recreation in the arid Chisos Mountains and in canyons along the river", "Big Bend National Park", "Texas", "National" },
                    { 6, "A remote oasis catering to camping and boating on the shore of a scenic desert canyon reservoir.", "Lake Owyhee State Park", "Oregon", "State" },
                    { 7, "Hat Rock is a geological formation that, along with another outcropping rock in the park called Boat Rock, are thought to be exposed remnants of a 12-million-year-old basalt flow.", "Hat Rock State Park", "Oregon", "State" },
                    { 8, "Tumalo State Park is located in the Deschutes River canyon, running along both sides of the river.", "Tumalo State Park", "Oregon", "State" },
                    { 9, "It covers 1,842 acres (7.45 km2) of land around 1,759-foot (536 m) Humbug Mountain, one of the tallest headlands on the Oregon coast.", "Humbug Mountain State Park", "Oregon", "State" },
                    { 10, "Cape Blanco extends farther west than any point of land in the contiguous United States (lower 48 states) except portions of the Olympic Peninsula in Washington.", "Cape Blanco State Park", "Oregon", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);
        }
    }
}
