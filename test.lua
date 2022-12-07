array={3,2,1,23,24,12}
for i=1,#array do

    for j=1,#array-i do
     if array[j+1] < array[j] then
         array[j+1], array[j] = array[j], array[j+1]
     end
    end
  end
  for k ,v in pairs(array) do
      print("k = " .. k .. " v = " .. v)
  end
 