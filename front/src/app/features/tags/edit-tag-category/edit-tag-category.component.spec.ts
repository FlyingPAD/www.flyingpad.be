import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditTagCategoryComponent } from './edit-tag-category.component';

describe('EditTagCategoryComponent', () => {
  let component: EditTagCategoryComponent;
  let fixture: ComponentFixture<EditTagCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [EditTagCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditTagCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
