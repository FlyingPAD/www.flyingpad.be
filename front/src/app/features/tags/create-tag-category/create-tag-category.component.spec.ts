import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CreateTagCategoryComponent } from './create-tag-category.component';

describe('CreateTagCategoryComponent', () => {
  let component: CreateTagCategoryComponent;
  let fixture: ComponentFixture<CreateTagCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CreateTagCategoryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(CreateTagCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
