import React from 'react'
import { HeaderTop } from './header-top/HeaderTop'
import { HeaderMiddle } from './header-middle/HeaderMiddle'
import { HeaderBottom } from './header-bottom/HeaderBottom'
export const Header = () => {
  return (
    <div>
        <HeaderTop/>
        <HeaderMiddle/>
        <HeaderBottom/>
       
    </div>
  )
}
