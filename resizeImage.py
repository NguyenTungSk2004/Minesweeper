import cv2

# Đọc tấm ảnh từ file
image = cv2.imread('iconGame.png')

# Thay đổi kích thước của tấm ảnh (image, (width, height))
resized_image = cv2.resize(image, (256,256))

# Lưu tấm ảnh đã được thay đổi kích thước
cv2.imwrite('icon.png', resized_image)