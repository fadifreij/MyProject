import { BrowserRouter, Route, Routes } from "react-router-dom";

import { Home } from './components/Home/Home';
import { Layout } from './components/Layout';
import { Shop } from './components/shop/shop'
import { ShopDetails } from "./components/shop-details/shop-details";
import { ShoppingCart } from "./components/shopping-cart/shopping-cart";
function App() {
  return (
    <BrowserRouter>
      <Routes >
        <Route path="/" element={<Layout />}>
          <Route index  element={<Home />} /> {/* Default route for '/' */}
          <Route path="/shop" element={<Shop />} />
          <Route path="/shop-details" element={<ShopDetails/>} />
          <Route path="/shopping-cart" element={<ShoppingCart/>}/>
        </Route>
        
      </Routes>
    </BrowserRouter>
  );
}

export default App;
