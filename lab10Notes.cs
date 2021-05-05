if (movie.Category == searching)
                    {
                        if (notFound)
                        {
                            Console.Write($"\nThese are my favorite {searching} movies:");
                            Console.WriteLine("\n");
                            notFound = false;
                        }
                        Console.WriteLine($"\"{movie.Title}\"");
                    }


