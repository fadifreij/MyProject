import { Routes } from '@angular/router';
import { HomeComponent  } from '../app/components/Home/Home.component'
import { ShopComponent } from './components/shop/shop.component';
import { ShopDetailsComponent } from './components/shop-details/shop-details.component';
import { ShoppingCartComponent } from './components/shopping-cart/shopping-cart.component';
import { CheckoutComponent } from './components/checkout/checkout.component';
import { BlogDetailsComponent } from './components/blog-details/blog-details.component';
import { BlogComponent } from './components/blog/blog.component';
import { ContactComponent } from './components/contact/contact.component';

export const routes: Routes = [
    { path: '', component: HomeComponent },
    { path: 'shop', component:ShopComponent},
    { path: 'shop-details', component:ShopDetailsComponent},
    { path: 'shopping-cart', component:ShoppingCartComponent},
    { path: 'checkout', component: CheckoutComponent },
    { path: 'blog-details', component: BlogDetailsComponent },
    { path: 'blog', component: BlogComponent },
    { path: 'contact', component: ContactComponent }
   
];
