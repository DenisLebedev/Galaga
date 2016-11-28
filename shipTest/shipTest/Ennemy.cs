using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace shipTest
{
    /**
     * An Ennemy can shoot move life death points
     */ 

    abstract class Ennemy
    {
        abstract public void updateSprite();

        abstract public void shoot();

        abstract public void move();

        abstract public int collide();

        abstract public int score();

        abstract public Rectangle getEnemy();

        //Add a collide Method

        /**
         * Return the path to the picture
         * The picture has to be specified
         */ 
        public string monsterPicPath(string creature)
        {
            string path;

            path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(path.IndexOf(":") + 2);
            path = System.IO.Path.Combine(path, ("Ressources\\" + creature));
            return path;
        }

    }
}
