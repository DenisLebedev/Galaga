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
    class GreenAlien : Ennemy
    {

        private int health;
        private int point;
        private bool sprite;
        Rectangle ennemy;

        public GreenAlien()
        {
            ennemy = new Rectangle();
            ennemy.Height = 30;
            ennemy.Width = 30;
            ennemy.Fill = new ImageBrush { ImageSource =
                               new BitmapImage(new Uri(monsterPicPath("enemyB1.bmp"),
                                                                        UriKind.Absolute))};
            point = 20;
            health = 2;
            sprite = false;

        }

        public override int collide()
        {
            if (health > 0)
                health--;
            return health;
        }

        public override void move()
        {
            throw new NotImplementedException();
        }

        public override int score()
        {
            return point;
        }

        public override void shoot()
        {
            throw new NotImplementedException();
        }


        public override void updateSprite()
        {
            if (health == 2)
            {
                if (sprite)
                {
                    ennemy.Fill = new ImageBrush{ ImageSource =
                                    new BitmapImage(new Uri(monsterPicPath("enemyB1.bmp"),
                                                                            UriKind.Absolute))};
                    sprite = false;
                }
                else
                {
                    ennemy.Fill = new ImageBrush{ImageSource =
                                    new BitmapImage(new Uri(monsterPicPath("enemyB2.bmp"),
                                                                            UriKind.Absolute))};
                    sprite = true;
                }
            }
            else
            {
                if (sprite)
                {
                    ennemy.Fill = new ImageBrush{ ImageSource =
                                    new BitmapImage(new Uri(monsterPicPath("enemyC1.bmp"),
                                                                            UriKind.Absolute))};
                    sprite = false;
                }
                else
                {
                    ennemy.Fill = new ImageBrush{ImageSource =
                                    new BitmapImage(new Uri(monsterPicPath("enemyC2.bmp"),
                                                                            UriKind.Absolute))};
                    sprite = true;
                }
            }
        }

        public override Rectangle getEnemy()
        {
            return ennemy;
        }

    }
}
