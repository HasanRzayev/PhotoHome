using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PhotoHome.Models.Entity;
using System.Drawing;

using System.Net;
using System.Reflection.Metadata;
using CloudinaryDotNet;
using System.Net;
using System.IO;
using System.Collections.Generic;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;
using System;

namespace PhotoHome.Models.Configurations
{


    public class Default 
    {

        public Dictionary<string,List<string>> GetDict()
        {
            Uri url = new Uri("https://burst.shopify.com/");

            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            //HtmlAgilityPack.HtmlNodeCollection basliqlar = dokuman.DocumentNode.SelectNodes("//section//a");
            int number = 0;
            //var nodes = dokuman.DocumentNode.SelectNodes("//a//img[@class='ez-resource-thumb__img']");
            var nodes = dokuman.DocumentNode.SelectNodes("//a[@class='photo-card__link-overlay']");
            string tam_link = "https://burst.shopify.com/";
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            List<string> list = new List<string>();
            foreach (var src in nodes)
            {
                int count = 0;
                string link = tam_link + src.Attributes["href"].Value;
                Uri url_2 = new Uri(link);
                WebClient client_2 = new WebClient();
                string html_2 = client_2.DownloadString(url_2);
                HtmlAgilityPack.HtmlDocument dokuman_2 = new HtmlAgilityPack.HtmlDocument();
                dokuman_2.LoadHtml(html_2);
                var option = dokuman_2.DocumentNode.SelectNodes("//a[@class='photo-tile__image-wrapper']");

                foreach (var im in option)
                {
                    try
                    {

                        if (count == 10) break;

                        list.Add(im.Attributes["href"].Value);
                        count++;
                    }
                    catch (Exception)
                    {

                        break;
                    }

                }




            }


            foreach (var item in list)
            {
                string link = tam_link + item;
                Uri url_2 = new Uri(link);
                WebClient client_2 = new WebClient();
                string html_2 = client_2.DownloadString(url_2);
                HtmlAgilityPack.HtmlDocument dokuman_2 = new HtmlAgilityPack.HtmlDocument();
                dokuman_2.LoadHtml(html_2);
                var option = dokuman_2.DocumentNode.SelectNodes("//a[@class='nowrap']");
                //Console.WriteLine(item);
                List<string> tags = new List<string>();
                int index = 1;
                if (option == null)
                {
                    dict.Add(link, tags);
                    continue;
                }
                foreach (var im in option)
                {


                    try
                    {
                        if (im.InnerText == null) break;
                        //Console.WriteLine(im.InnerText);
                        tags.Add(im.InnerText);

                        //list.Add(im.Attributes["href"].Value);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    Thread.Sleep(20);

                }
                dict.Add(link, tags);
                Console.WriteLine("----------------------------------");
                Console.WriteLine(index++);
            }


            return dict;
        }

        public List<string> GetTagNames()
        {

            List<string> lazim = new List<string>();

            lazim.Add("Architecture                                                         ");

            lazim.Add("City                                                         ");
            lazim.Add("Backgrounds                                                  ");
            lazim.Add("Sale                                                         ");
            lazim.Add("Store                                                        ");
            lazim.Add("Market                                                       ");
            lazim.Add("Local                                                        ");
            lazim.Add("Around the World                                             ");
            lazim.Add("Asia                                                         ");
            lazim.Add("Lunar New Year                                               ");
            lazim.Add("China                                                        ");
            lazim.Add("Fashion                                                      ");
            lazim.Add("Travel                                                       ");
            lazim.Add("Trip                                                         ");
            lazim.Add("Dancing                                                      ");
            lazim.Add("Earth                                                        ");
            lazim.Add("Diwali                                                       ");
            lazim.Add("Mobile Backgrounds                                           ");
            lazim.Add("Cool Background                                              ");
            lazim.Add("India                                                        ");
            lazim.Add("Rocks                                                        ");
            lazim.Add("Outdoor                                                      ");
            lazim.Add("Hiking                                                       ");
            lazim.Add("Iceland                                                      ");
            lazim.Add("Walk                                                         ");
            lazim.Add("Hill                                                         ");
            lazim.Add("Green                                                        ");
            lazim.Add("Nature                                                       ");
            lazim.Add("Adventure                                                    ");
            lazim.Add("Landscape                                                    ");
            lazim.Add("USA                                                          ");
            lazim.Add("Grand Canyon                                                 ");
            lazim.Add("Arizona                                                      ");
            lazim.Add("America                                                      ");
            lazim.Add("Mountain                                                     ");
            lazim.Add("Spring                                                       ");
            lazim.Add("Sunrise                                                      ");
            lazim.Add("Morning                                                      ");
            lazim.Add("Village                                                      ");
            lazim.Add("Japan                                                        ");
            lazim.Add("Path                                                         ");
            lazim.Add("Men                                                          ");
            lazim.Add("Friends                                                      ");
            lazim.Add("People                                                       ");
            lazim.Add("Water                                                        ");
            lazim.Add("Lake                                                         ");
            lazim.Add("Boat                                                         ");
            lazim.Add("Ocean                                                        ");
            lazim.Add("Home                                                         ");
            lazim.Add("House                                                        ");
            lazim.Add("Building                                                     ");
            lazim.Add("Sea                                                          ");
            lazim.Add("California                                                   ");
            lazim.Add("Good Morning                                                 ");
            lazim.Add("Sun                                                          ");
            lazim.Add("Walls                                                        ");
            lazim.Add("Paris                                                        ");
            lazim.Add("Light                                                        ");
            lazim.Add("Window                                                       ");
            lazim.Add("France                                                       ");
            lazim.Add("Flowers                                                      ");
            lazim.Add("Laptop                                                       ");
            lazim.Add("Computer                                                     ");
            lazim.Add("Keyboard                                                     ");
            lazim.Add("Meetings                                                     ");
            lazim.Add("Presentation                                                 ");
            lazim.Add("Furniture                                                    ");
            lazim.Add("Room                                                         ");
            lazim.Add("Living room                                                  ");
            lazim.Add("Home Office                                                  ");
            lazim.Add("Flower Background                                            ");
            lazim.Add("Women                                                        ");
            lazim.Add("Business                                                     ");
            lazim.Add("Office                                                       ");
            lazim.Add("Writing                                                      ");
            lazim.Add("Camera                                                       ");
            lazim.Add("Technology                                                   ");
            lazim.Add("Desk                                                         ");
            lazim.Add("Professional                                                 ");
            lazim.Add("Calendar                                                     ");
            lazim.Add("Young adult                                                  ");
            lazim.Add("Home decor                                                   ");
            lazim.Add("Work                                                         ");
            lazim.Add("Entrepreneur                                                 ");
            lazim.Add("Business woman                                               ");
            lazim.Add("Women &#39;s Day                                             ");
            lazim.Add("Books                                                        ");
            lazim.Add("Design                                                       ");
            lazim.Add("Minimalist                                                   ");
            lazim.Add("White                                                        ");
            lazim.Add("Graphic Designer                                             ");
            lazim.Add("Creative                                                     ");
            lazim.Add("Photographer                                                 ");
            lazim.Add("Startup                                                      ");
            lazim.Add("Ideas                                                        ");
            lazim.Add("Education                                                    ");
            lazim.Add("Reading                                                      ");
            lazim.Add("Hands                                                        ");
            lazim.Add("Couple                                                       ");
            lazim.Add("Jewelry                                                      ");
            lazim.Add("Love                                                         ");
            lazim.Add("Bracelet                                                     ");
            lazim.Add("Necklace                                                     ");
            lazim.Add("Accessories                                                  ");
            lazim.Add("Romantic                                                     ");
            lazim.Add("Mental Health                                                ");
            lazim.Add("Portraits                                                    ");
            lazim.Add("Emotion                                                      ");
            lazim.Add("Sad                                                          ");
            lazim.Add("Motivation                                                   ");
            lazim.Add("Success                                                      ");
            lazim.Add("Inspirational                                                ");
            lazim.Add("Community                                                    ");
            lazim.Add("Ribbons                                                      ");
            lazim.Add("Relax                                                        ");
            lazim.Add("Models                                                       ");
            lazim.Add("Letter Board                                                 ");
            lazim.Add("Black and White                                              ");
            lazim.Add("Help                                                         ");
            lazim.Add("Black                                                        ");
            lazim.Add("Fitness                                                      ");
            lazim.Add("Yoga                                                         ");
            lazim.Add("Children                                                     ");
            lazim.Add("Sports                                                       ");
            lazim.Add("Family                                                       ");
            lazim.Add("Mom                                                          ");
            lazim.Add("Gym                                                          ");
            lazim.Add("Exercise                                                     ");
            lazim.Add("Body - positivity                                            ");
            lazim.Add("Body                                                         ");
            lazim.Add("Wellness                                                     ");
            lazim.Add("Mothers Day                                                  ");
            lazim.Add("Workout                                                      ");
            lazim.Add("Strength                                                     ");
            lazim.Add("Leadership                                                   ");
            lazim.Add("            Life                                             ");
            lazim.Add("Teamwork                                                     ");
            lazim.Add("            Team                                             ");
            lazim.Add("Crossfit                                                     ");
            lazim.Add("Run                                                          ");
            lazim.Add("Athlete                                                      ");
            lazim.Add("Soccer                                                       ");
            lazim.Add("Field                                                        ");
            lazim.Add("Suits                                                        ");
            lazim.Add("Businessman                                                  ");
            lazim.Add("Urban Life                                                   ");
            lazim.Add("Street                                                       ");
            lazim.Add("Future                                                       ");
            lazim.Add("Night                                                        ");
            lazim.Add("School                                                       ");
            lazim.Add("Science                                                      ");
            lazim.Add("Lab                                                          ");
            lazim.Add("Dogs                                                         ");
            lazim.Add("Animals                                                      ");
            lazim.Add("Pets                                                         ");
            lazim.Add("Pets & amp; Animals                                          ");
            lazim.Add("Seasons                                                      ");
            lazim.Add("Pillow                                                       ");
            lazim.Add("Arts                                                         ");
            lazim.Add("Environment                                                  ");
            lazim.Add("Flatlay                                                      ");
            lazim.Add("Thanksgiving                                                 ");
            lazim.Add("Dessert                                                      ");
            lazim.Add("Happy Holidays                                               ");
            lazim.Add("Pumpkin                                                      ");
            lazim.Add("Vegetables                                                   ");
            lazim.Add("Harvest                                                      ");
            lazim.Add("Valentines Day                                               ");
            lazim.Add("Trees                                                        ");
            lazim.Add("Forest                                                       ");
            lazim.Add("Love Background                                              ");
            lazim.Add("Leaves                                                       ");
            lazim.Add("Drinks                                                       ");
            lazim.Add("Pink                                                         ");
            lazim.Add("Tea                                                          ");
            lazim.Add("Tea Cup                                                      ");
            lazim.Add("Ice                                                          ");
            lazim.Add("Table                                                        ");
            lazim.Add("Wood                                                         ");
            lazim.Add("Coffee Cup                                                   ");
            lazim.Add("Music                                                        ");
            lazim.Add("Restaurant                                                   ");
            lazim.Add("Plants                                                       ");
            lazim.Add("Tattoo                                                       ");
            lazim.Add("Person on Computer                                           ");
            lazim.Add("Social Media                                                 ");
            lazim.Add("Kitchen                                                      ");
            lazim.Add("Breakfast                                                    ");
            lazim.Add("Talking                                                      ");
            lazim.Add("Conversation                                                 ");
            lazim.Add("Bedroom                                                      ");
            lazim.Add("Apartment                                                    ");
            lazim.Add("bed                                                          ");
            lazim.Add("Cats                                                         ");
            lazim.Add("Video Call Backgrounds                                       ");
            lazim.Add("Colourful                                                    ");
            lazim.Add("Rainbow                                                      ");
            lazim.Add("Baby                                                         ");
            lazim.Add("Craft / DIY                                                  ");
            lazim.Add("Cooking                                                      ");
            lazim.Add("Hug                                                          ");
            lazim.Add("iPhone                                                       ");
            lazim.Add("Phones & amp; Cases                                          ");
            lazim.Add("Thought Catalog                                              ");
            lazim.Add("Hair                                                         ");
            lazim.Add("Beauty                                                       ");
            lazim.Add("Haircut                                                      ");
            lazim.Add("Painting                                                     ");
            lazim.Add("Canvas                                                       ");
            lazim.Add("Rose                                                         ");
            lazim.Add("Bouquet                                                      ");
            lazim.Add("Red                                                          ");
            lazim.Add("Makeup                                                       ");
            lazim.Add("Cosmetics                                                    ");
            lazim.Add("Watch                                                        ");
            lazim.Add("Just Add Water                                               ");
            lazim.Add("Lipstick                                                     ");
            lazim.Add("Fun                                                          ");
            lazim.Add("Blue                                                         ");
            lazim.Add("Lips                                                         ");
            lazim.Add("Healthy Lifestyle                                            ");
            lazim.Add("Toronto                                                      ");
            lazim.Add("Skyline                                                      ");
            lazim.Add("Health                                                       ");
            lazim.Add("Good Vibes                                                   ");
            lazim.Add("Cloud                                                        ");
            lazim.Add("Basketball                                                   ");
            lazim.Add("Winter                                                       ");
            lazim.Add("Weather                                                      ");
            lazim.Add("Pink Background                                              ");
            lazim.Add("Weight Loss                                                  ");
            lazim.Add("Pants                                                        ");
            lazim.Add("Color Backgrounds                                            ");
            lazim.Add("Park                                                         ");
            lazim.Add("Profile                                                      ");
            lazim.Add("Communication                                                ");
            lazim.Add("Marketing                                                    ");
            lazim.Add("Ecommerce                                                    ");
            lazim.Add("Graphic Design                                               ");
            lazim.Add("Globe                                                        ");
            lazim.Add("Drawing                                                      ");
            lazim.Add("Graph                                                        ");
            lazim.Add("Hootsuite                                                    ");
            lazim.Add("Christmas                                                    ");
            lazim.Add("Holidays                                                     ");
            lazim.Add("Kids                                                         ");
            lazim.Add("Boys                                                         ");
            lazim.Add("Happy                                                        ");
            lazim.Add("Father                                                       ");
            lazim.Add("Newborn                                                      ");
            lazim.Add("Feet                                                         ");
            lazim.Add("Sleep                                                        ");
            lazim.Add("Skincare                                                     ");
            lazim.Add("Skin                                                         ");
            lazim.Add("Feel Good Photos                                             ");
            lazim.Add("Cute                                                         ");
            lazim.Add("Toys                                                         ");
            lazim.Add("Playtime                                                     ");
            lazim.Add("Student                                                      ");
            lazim.Add("Back to School                                               ");
            lazim.Add("Classroom                                                    ");
            lazim.Add("Summer                                                       ");
            lazim.Add("Girls                                                        ");
            lazim.Add("Dress                                                        ");
            lazim.Add("Gifts                                                        ");
            lazim.Add("Christmas Tree                                               ");
            lazim.Add("Holiday                                                      ");
            lazim.Add("Hat                                                          ");
            lazim.Add("Wallpapers                                                   ");
            lazim.Add("Textures                                                     ");
            lazim.Add("Abstract                                                     ");
            lazim.Add("Pattern                                                      ");
            lazim.Add("Sky                                                          ");
            lazim.Add("Space                                                        ");
            lazim.Add("Stars                                                        ");
            lazim.Add("Sunset                                                       ");
            lazim.Add("Desert                                                       ");
            lazim.Add("Wave                                                         ");
            lazim.Add("Sign Language                                                ");
            lazim.Add("Clothes                                                      ");
            lazim.Add("Leather                                                      ");
            lazim.Add("Shopify                                                      ");
            lazim.Add("Glasses                                                      ");
            lazim.Add("Shoes                                                        ");
            lazim.Add("Floral                                                       ");
            lazim.Add("Shipping                                                     ");
            lazim.Add("Box                                                          ");
            lazim.Add("Celebrate                                                    ");
            lazim.Add("Vintage                                                      ");
            lazim.Add("Alcohol                                                      ");
            lazim.Add("Bike                                                         ");
            lazim.Add("Bridges                                                      ");
            lazim.Add("Wedding                                                      ");
            lazim.Add("Bride                                                        ");
            lazim.Add("Vacation                                                     ");
            lazim.Add("San Francisco                                                ");
            lazim.Add("Gold                                                         ");
            lazim.Add("Sound                                                        ");
            lazim.Add("Headphones                                                   ");
            lazim.Add("Online                                                       ");
            lazim.Add("Pug                                                          ");
            lazim.Add("Internet                                                     ");
            lazim.Add("Tablets                                                      ");
            lazim.Add("Data                                                         ");
            lazim.Add("Diversity                                                    ");
            lazim.Add("Beard                                                        ");
            lazim.Add("Boho                                                         ");
            lazim.Add("Hipster                                                      ");
            lazim.Add("Tie                                                          ");
            lazim.Add("Neon                                                         ");
            lazim.Add("Shirt                                                        ");
            lazim.Add("Barbershop                                                   ");
            lazim.Add("Yellow                                                       ");
            lazim.Add("Yellow Background                                            ");
            lazim.Add("Rain                                                         ");
            lazim.Add("Reflection                                                   ");
            lazim.Add("Blur - Background                                            ");
            lazim.Add("Energy                                                       ");
            lazim.Add("Smoke                                                        ");
            lazim.Add("Orange                                                       ");
            lazim.Add("Silver                                                       ");
            lazim.Add("Fruit                                                        ");
            lazim.Add("Black Friday Cyber Monday                                    ");
            lazim.Add("Shopping                                                     ");
            lazim.Add("Retail                                                       ");
            lazim.Add("BFCM                                                         ");
            lazim.Add("Trabalho de casa                                             ");
            lazim.Add("Planning                                                     ");
            lazim.Add("Camping                                                      ");
            lazim.Add("Bag                                                          ");
            lazim.Add("Backpack                                                     ");
            lazim.Add("Farm                                                         ");
            lazim.Add("Waterfalls                                                   ");
            lazim.Add("Egg                                                          ");
            lazim.Add("Shop                                                         ");
            lazim.Add("Dinner                                                       ");
            lazim.Add("Pizza                                                        ");
            lazim.Add("Pasta                                                        ");
            lazim.Add("Products                                                     ");
            lazim.Add("Luxury                                                       ");
            lazim.Add("Clock                                                        ");
            lazim.Add("Time                                                         ");
            lazim.Add("Numbers                                                      ");
            lazim.Add("Digital downloads                                            ");
            lazim.Add("Online Shopping                                              ");
            lazim.Add("Handbag                                                      ");
            lazim.Add("T - Shirts                                                   ");
            lazim.Add("Ring                                                         ");
            lazim.Add("Marriage                                                     ");
            lazim.Add("Arrow                                                        ");
            lazim.Add("Mexico                                                       ");
            lazim.Add("Spain                                                        ");
            lazim.Add("Bird                                                         ");
            lazim.Add("Australia                                                    ");
            lazim.Add("Duck                                                         ");
            lazim.Add("Cute Animals                                                 ");
            lazim.Add("Zoo                                                          ");
            lazim.Add("Octopus                                                      ");
            lazim.Add("Funny                                                        ");
            lazim.Add("Puppy                                                        ");
            lazim.Add("Eagle                                                        ");
            lazim.Add("Grass                                                        ");
            lazim.Add("Meditation                                                   ");
            lazim.Add("Calm                                                         ");
            lazim.Add("Rivers                                                       ");
            lazim.Add("Stretch                                                      ");
            return lazim;

        }
        public List<string> GetImages()
        {

            Uri url = new Uri("https://burst.shopify.com/");

            WebClient client = new WebClient();
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);
            List<string> list = new List<string>();
            //HtmlAgilityPack.HtmlNodeCollection basliqlar = dokuman.DocumentNode.SelectNodes("//section//a");
            int number = 0;
            //var nodes = dokuman.DocumentNode.SelectNodes("//a//img[@class='ez-resource-thumb__img']");
            var nodes = dokuman.DocumentNode.SelectNodes("//a[@class='photo-card__link-overlay']");
            string tam_link = "https://burst.shopify.com/";
            //*[@id="app"]/div/div[3]/div[2]/div/div/div/div[2]/figure[1]/div/div/a/div/div[2]/img

            List<string> images = new List<string>();
            foreach (var src in nodes)
            {
                int count = 0;
                string link = tam_link + src.Attributes["href"].Value;


                Uri url_2 = new Uri(link);

                WebClient client_2 = new WebClient();
                string html_2 = client_2.DownloadString(url_2);
                HtmlAgilityPack.HtmlDocument dokuman_2 = new HtmlAgilityPack.HtmlDocument();
                dokuman_2.LoadHtml(html_2);
                var option = dokuman_2.DocumentNode.SelectNodes("//img");

                foreach (var im in option)
                {

                    if (count == 10) break;
                    images.Add(im.Attributes["src"].Value);
                    Console.WriteLine(im.Attributes["src"].Value);
                    count++;
                }




            }
            Console.WriteLine(images.Count);
            return images;

        }


    }


}
