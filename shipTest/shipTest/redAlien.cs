using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace shipTest
{
    class RedAlien : Ennemy
    {

        private int health;
        private int point;
        private bool sprite;
        Rectangle ennemy;

        public RedAlien()
        {
            ennemy = new Rectangle();
            ennemy.Height = 30;
            ennemy.Width = 30;
            ennemy.Fill = new ImageBrush { ImageSource =
                               new BitmapImage(new Uri(monsterPicPath("enemyA1.bmp"),
                                                                        UriKind.Absolute))};
            point = 10;
            health = 1;
            sprite = false;

        }

        public override void shoot()
        {
            throw new NotImplementedException();
        }

        public override void move()
        {
            throw new NotImplementedException();
        }

        public override int collide()
        {
            if (health > 0)
                health--;
            return health;
        }

        public override int score()
        {
            return point;
        }

        public override void updateSprite()
        {
            if (sprite)
            {
                ennemy.Fill = new ImageBrush { ImageSource = 
                                new BitmapImage(new Uri(monsterPicPath("enemyA1.bmp"), 
                                                                        UriKind.Absolute)) };
                sprite = false;
            }
            else
            {
                ennemy.Fill = new ImageBrush { ImageSource = 
                                new BitmapImage(new Uri(monsterPicPath("enemyA2.bmp"), 
                                                                        UriKind.Absolute)) };
                sprite = true;
            }
        }

        public override Rectangle getEnemy()
        {
            return ennemy;
        }
    }
}
