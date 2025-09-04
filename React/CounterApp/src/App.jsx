import { useReducer, useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {
  const user = {name : 'nvk',age : 23,place:'mangalore'}
  const{name,...rest} = user
  console.log(name)
  console.log(user)
  

  let count = 0;
  const increment = ()=>{
    count++;
    document.getElementById("123").innerText = count
  }
  const decrement = ()=>{
    count--;
    document.getElementById("123").innerText = count
  }
  
  return(
    <div>
      <h1 id = "123" style={{ color: 'black' }}>0</h1>
      <button style={{ backgroundColor: 'aqua', color: 'white' }}onClick={increment}>INCREMENT</button>
      <button style={{ backgroundColor: 'crimson', color: 'white' }}onClick={decrement}>DECREMENT</button>
    </div>
  )
}

export default App
